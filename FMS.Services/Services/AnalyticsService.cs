using AutoMapper;
using FMS.Contracts;
using FMS.Core.Services;
using FMS.Data.Contexts;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using FMS.Entities.Models;
using FMS.Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Services.Services
{

    public class AnalyticsService : BaseAuditableService, IAnalyticsService
    {
        private readonly IMapper _mapper;
        private readonly FMSContext _context;

        public AnalyticsService(IUnitOfWorkFactory unitOfWorkFactory, FMSContext context, IMapper mapper) : base(unitOfWorkFactory)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<AnalyticsDTO> GetBookingCapacityAnalyticsDataAsync(int floorId, CancellationToken cancellationToken)
        {
            var wingDetailsDTOs = _mapper.Map<List<WingDetailDTO>>(_context.WingDetails.OrderBy(a => a.Order).ToList());

            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();
            var bookingDetailRepository = unitOfWork.CreateRepository<BookingDetail>();
            var statusRepository = unitOfWork.CreateRepository<StatusType>();

            var retVal = _mapper.Map<List<DeskDetailDTO>>(
                await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail).Where(a => a.FloorDetail.Id == floorId)
                .ToListAsync(cancellationToken));

            var status = _mapper.Map<StatusTypeDTO>(await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken));

            DateTime todaysDate = DateTime.Now;
            String todaysShortDate = todaysDate.ToShortDateString();

            //var bookedSeatsForToday = await bookingDetailRepository.Query().Include(a => a.Desk).Where(a => a.StatusTypeId != 3 && DateTime.Compare(a.BookingFromDate.Value.Date, DateTime.Now.Date) == 0).ToListAsync(cancellationToken);
            var bookedSeatsForToday = await bookingDetailRepository.Query().Include(a => a.Desk).
                Where(a => ((a.BookingFromDate.Value.Date >= Convert.ToDateTime(todaysShortDate)
                    && a.BookingFromDate.Value.Date <= Convert.ToDateTime(todaysShortDate))

                    || (a.BookingToDate.Value.Date >= Convert.ToDateTime(todaysShortDate)
                    && a.BookingToDate.Value.Date <= Convert.ToDateTime(todaysShortDate))

                    || (a.BookingFromDate.Value.Date <= Convert.ToDateTime(todaysShortDate)
                    && a.BookingToDate.Value.Date >= Convert.ToDateTime(todaysShortDate)))

                    && a.StatusTypeId == status.Id).ToListAsync(cancellationToken);

            List<string> chartLabels = new List<string>();

            var wingWiseLabels = new List<KeyValuePair<int, string>>();

            var wingWiseDeskData = new List<KeyValuePair<int, int>>();
            var wingWiseBookingData = new List<KeyValuePair<int, int>>();

            var bookingCapicityAnalyticsData = new AnalyticsDTO();

            foreach (var wing in wingDetailsDTOs.OrderBy(a => a.Id))
            {
                var firstWingDesk = retVal.Where(a => a.WingDetail.Id == wing.Id).FirstOrDefault();
                var wingBookings = bookedSeatsForToday.Where(b => b.Desk.WingDetailId == wing.Id);

                if (firstWingDesk != null)
                {
                    wingWiseLabels.Add(new KeyValuePair<int, string>(wing.Id, firstWingDesk.LocationDetail.Name + " - " + firstWingDesk.FloorDetail.Name + " - " + firstWingDesk.WingDetail.Name));

                    wingWiseDeskData.Add(new KeyValuePair<int, int>(wing.Id, retVal.Where(a => a.WingDetail.Id == wing.Id).ToList().Count()));
                    int wingBooking = 0;
                    if (bookedSeatsForToday.Where(b => b.Desk.WingDetailId == wing.Id) != null)
                    {
                        wingBooking = bookedSeatsForToday.Where(b => b.Desk.WingDetailId == wing.Id).ToList().Count();
                    }

                    wingWiseBookingData.Add(new KeyValuePair<int, int>(wing.Id, wingBooking));
                }
            }

            bookingCapicityAnalyticsData.ChartLabels = wingWiseLabels.Select(a => a.Value).ToList();
            bookingCapicityAnalyticsData.ChartData = new List<AnalyticData>()
                {
                    new AnalyticData()
                    {
                        Label = "Booked",
                        Data = wingWiseBookingData.Select(a=>a.Value).ToList()
                    },
                    new AnalyticData()
                    {
                        Label = "Capacity",
                        Data = wingWiseDeskData.Select(a=>a.Value).ToList()
                    }
                };

            return await Task.FromResult(bookingCapicityAnalyticsData);
        }


        public async Task<AnalyticsDTO> GetFrequentBookingAnalyticsDataAsync(int wingId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();
            var bookingDetailRepository = unitOfWork.CreateRepository<BookingDetail>();
            var wingWiseLabels = new List<KeyValuePair<string, int>>();

            var retVal = new AnalyticsDTO();
            int lastDeskId = 0;

            var deskDetailDTO = _mapper.Map<List<DeskDetailDTO>>(
                await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail)
                .Where(a => a.WingDetailId == wingId)
                .ToListAsync(cancellationToken));

            var bookedSeats = await bookingDetailRepository.Query().Include(a => a.Desk).Include(a => a.Desk.LocationDetail).Include(a => a.Desk.FloorDetail).Include(a => a.Desk.WingDetail)
                .Where(a => deskDetailDTO.Select(a => a.Id).ToList().Contains(a.DeskId.Value) && a.StatusTypeId != 3).OrderBy(a => a.DeskId).ToListAsync(cancellationToken);
            if (bookedSeats.Count > 0)
            {
                foreach (var seat in bookedSeats)
                {
                    if (seat.DeskId != lastDeskId)
                    {
                        var bookedSeatsForDesk = bookedSeats.Where(a => a.DeskId == seat.DeskId);
                        var daysCount = 0.0;
                        if (bookedSeatsForDesk.Any())
                        {
                            foreach (var bookedSeat in bookedSeatsForDesk)
                            {
                                daysCount += ((bookedSeat.BookingToDate.Value - bookedSeat.BookingFromDate.Value).TotalDays) + 1;
                            }
                        }
                        var seats = daysCount; // bookedSeats.Count(a => a.DeskId == seat.DeskId);
                        wingWiseLabels.Add(new KeyValuePair<string, int>(seat.Desk.FloorDetail.Name + " - " + seat.Desk.WingDetail.Name + " - " + seat.Desk.SeatNumber, Convert.ToInt32(seats)));
                        lastDeskId = seat.DeskId.Value;
                    }
                }
            }
            else
            {
                var emptyDataSet = deskDetailDTO.Take(10).OrderBy(a => a.Id);
                emptyDataSet.ToList().ForEach(seat =>
                {
                    wingWiseLabels.Add(new KeyValuePair<string, int>(seat.FloorDetail.Name + " - " + seat.WingDetail.Name + " - " + seat.SeatNumber, 0));
                });
            }
            var wingWiseLabelsInOrder = wingWiseLabels.OrderByDescending(s => s.Value);
            wingWiseLabels = wingWiseLabelsInOrder.ToList();

            retVal.ChartLabels = wingWiseLabels.Take(10).Select(a => a.Key).ToList();
            retVal.ChartData = new List<AnalyticData>()
                {
                    new AnalyticData()
                    {
                        Label = string.Empty,
                        Data = wingWiseLabels.Take(10).Select(a=>a.Value).ToList()
                    }
                };

            return await Task.FromResult(retVal);
        }

        public async Task<AnalyticsDTO> GetLocationWiseBookingAnalyticsDataAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();
            var bookingDetailRepository = unitOfWork.CreateRepository<BookingDetail>();
            var locationWiseLabels = new List<KeyValuePair<string, int>>();

            var retVal = new AnalyticsDTO();
            var deskDetailDTO = _mapper.Map<List<DeskDetailDTO>>(
                await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail)
                .ToListAsync(cancellationToken));
            var totalSeatsAvailabelData = deskDetailDTO.Count();
            var totalSeatAvailableLable = "Total Desks";
            var bookedSeats = await bookingDetailRepository.Query().Include(a => a.Desk).Include(a => a.Desk.LocationDetail).Include(a => a.Desk.FloorDetail).Include(a => a.Desk.WingDetail)
                .Where(a => deskDetailDTO.Select(a => a.Id).ToList().Contains(a.DeskId.Value) && a.StatusTypeId != 3).OrderBy(a => a.DeskId).ToListAsync(cancellationToken);

            var groupedData = bookedSeats.GroupBy(x => x.Desk.LocationDetailId).ToList();
            groupedData.ToList().ForEach(seat =>
            {
                var lable = seat.Select(x => x.Desk.LocationDetail.Name).FirstOrDefault();
                locationWiseLabels.Add(new KeyValuePair<string, int>(lable, seat.Count()));
            });
            retVal.ChartLabels = locationWiseLabels.Take(10).Select(a => a.Key).ToList();
            retVal.ChartLabels.Add(totalSeatAvailableLable);
            locationWiseLabels.Add(new KeyValuePair<string, int>("", totalSeatsAvailabelData));
            retVal.ChartData = new List<AnalyticData>()
                {
                    new AnalyticData()
                    {
                        Label = string.Empty,
                        Data = locationWiseLabels.Take(10).Select(a=>a.Value).ToList()
                    }
                };



            return await Task.FromResult(retVal);
        }
    }
}
