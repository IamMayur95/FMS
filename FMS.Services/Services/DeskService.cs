using AutoMapper;
using FMS.Contracts;
using FMS.Core.Common.Contracts.Configuration;
using FMS.Core.Common.Extensions;
using FMS.Core.Services;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using FMS.Entities.Models;
using FMS.Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Services.Services
{

    public class DeskService : BaseAuditableService, IDeskService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationSettings _applicationSettings;

        public DeskService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper) : base(unitOfWorkFactory)
        {
            _mapper = mapper;
        }

        public async Task<bool> CancelBookingAsync(BookingDetailDTO request, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>(false);
            var statusRepository = unitOfWork.CreateRepository<StatusType>();

            var bookedStatus = await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken);
            var cancelStatus = await statusRepository.Query().Where(a => a.Name == "Cancelled").FirstOrDefaultAsync(cancellationToken);

            var bookingDetail = await bookingRepository.Query().Where(a => a.Id == request.Id && a.StatusTypeId == bookedStatus.Id).FirstOrDefaultAsync(cancellationToken);
            if (bookingDetail is not null)
            {
                bookingDetail.StatusTypeId = cancelStatus.Id;
                bookingDetail.CancelledByUserId = request.CancelledByUserId;
                bookingDetail.CancelledDate = DateTime.Now.Date;
            }
            await unitOfWork.SaveAsync(cancellationToken);
            return true;

        }

        public async Task<List<BookingDetailDTO>> GetAllDeskBookingsAsync(int userId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>();

            var retVal = _mapper.Map<List<BookingDetailDTO>>(
                await bookingRepository.Query().Include(a => a.BookedByUser).Include(a => a.CancelledByUser).Include(a => a.Desk).Include(a => a.Desk.LocationDetail)
                .Include(a => a.Desk.BuildingDetail).Include(a => a.Desk.FloorDetail).Include(a => a.Desk.WingDetail).Include(a => a.StatusType)
                .Where(a => a.DeskId > 0).Where(a => a.UserId == userId).ToListAsync(cancellationToken));
            return retVal.OrderByDescending(a => a.Id).ToList();
        }

        public async Task<BookingDetailDTO> GetBookingDetailsAsync(int bookingId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>();

            var retVal = _mapper.Map<BookingDetailDTO>(
                await bookingRepository.Query().Include(a => a.BookedByUser).Include(a => a.CancelledByUser).Include(a => a.Desk).Include(a => a.Desk.LocationDetail)
                .Include(a => a.Desk.BuildingDetail).Include(a => a.Desk.FloorDetail).Include(a => a.Desk.WingDetail).Include(a => a.StatusType)
                .Where(a => a.Id == bookingId).FirstOrDefaultAsync(cancellationToken));
            return retVal;
        }

        public async Task<List<BookingDetailDTO>> GetAllDeskBookingsForAllUsersAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>();

            var retVal = _mapper.Map<List<BookingDetailDTO>>(
                await bookingRepository.Query().Include(a => a.BookedByUser).Include(a => a.CancelledByUser).Include(a => a.Desk).Include(a => a.Desk.LocationDetail)
                .Include(a => a.Desk.BuildingDetail).Include(a => a.Desk.FloorDetail).Include(a => a.Desk.WingDetail).Include(a => a.StatusType)
                .Where(a => a.DeskId > 0).ToListAsync(cancellationToken));
            return retVal.OrderByDescending(a => a.Id).ToList();
        }

        public async Task<List<DeskDetailDTO>> GetAllDesksAsync(SearchDeskRequestDTO requestDTO, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();
            var bookingDetailRepository = unitOfWork.CreateRepository<BookingDetail>();
            var statusRepository = unitOfWork.CreateRepository<StatusType>();

            var status = _mapper.Map<StatusTypeDTO>(await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken));
            var retVal = _mapper.Map<List<DeskDetailDTO>>(
                await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail)
                .Where(a => a.LocationDetailId == requestDTO.Location.Id).ToListAsync(cancellationToken));

            var bookedSeatsForSelectedDate = await bookingDetailRepository.Query().Include(a => a.BookedByUser).
                Where(a => ((a.BookingFromDate.Value.Date >= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingFromDate.Value.Date <= Convert.ToDateTime(requestDTO.ToDate))

                    || (a.BookingToDate.Value.Date >= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingToDate.Value.Date <= Convert.ToDateTime(requestDTO.ToDate))

                    || (a.BookingFromDate.Value.Date <= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingToDate.Value.Date >= Convert.ToDateTime(requestDTO.ToDate)))

                    && a.StatusTypeId == status.Id).ToListAsync(cancellationToken);

            //var bookedSeatsForSelectedDate = await bookingDetailRepository.Query().Where(a => a.BookingFromDate.Value.Date <= Convert.ToDateTime(requestDTO.FromDate) &&
            // Convert.ToDateTime(requestDTO.ToDate) <= a.BookingToDate.Value.Date && a.StatusTypeId == status.Id).ToListAsync(cancellationToken);
            if (requestDTO.Floor != null && requestDTO.Floor.Id > 0)
            {
                retVal = retVal.Where(a => a.FloorDetailId == requestDTO.Floor.Id).ToList();
            }

            if (requestDTO.Wing != null && requestDTO.Wing.Id > 0)
            {
                retVal = retVal.Where(a => a.WingDetailId == requestDTO.Wing.Id).ToList();
            }
            retVal = retVal.Where(a => !bookedSeatsForSelectedDate.Select(b => b.DeskId).Contains(a.Id)).ToList();

            return retVal.OrderBy(a => a.SeatNumber).ToList();
        }

        public async Task<DeskDetailDTO> GetDeskDetailAsync(GetDeskDetailDTO request, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();
            var statusRepository = unitOfWork.CreateRepository<StatusType>();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>();
            var bookingDetailRepository = unitOfWork.CreateRepository<BookingDetail>();
            var status = _mapper.Map<List<StatusTypeDTO>>(await statusRepository.Query().ToListAsync(cancellationToken));

            var retVal = _mapper.Map<DeskDetailDTO>(
                await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail)
                .Where(a => a.SeatNumber == request.DeskNumber).FirstOrDefaultAsync(cancellationToken));

            var bookedStatus = _mapper.Map<StatusTypeDTO>(await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken));
            var cancelledStatus = _mapper.Map<StatusTypeDTO>(await statusRepository.Query().Where(a => a.Name == "Cancelled").FirstOrDefaultAsync(cancellationToken));

            var bookingDetail = await bookingDetailRepository.Query().Include(a => a.BookedByUser).Where(a => a.BookingFromDate.Value.Date <= Convert.ToDateTime(request.FromDate).Date &&
            Convert.ToDateTime(request.ToDate).Date <= a.BookingToDate.Value.Date && a.StatusTypeId == bookedStatus.Id).Where(a => a.DeskId == retVal.Id).FirstOrDefaultAsync(cancellationToken);

            if (retVal is null)
            {
                retVal = new DeskDetailDTO
                {
                    BuildingDetailId = 0,
                    Id = 0,
                    FloorDetailId = 0,
                    LocationDetailId = 0,
                    SeatNumber = string.Empty,
                    StatusTypeId = status.Where(a => a.Name == "Maintenance").FirstOrDefault().Id,
                    StatusType = status.Where(a => a.Name == "Maintenance").FirstOrDefault(),
                    WingDetailId = 0
                };
                return retVal;
            }

            retVal.StatusType = status.Where(a => a.Name == "Free").FirstOrDefault();
            retVal.StatusTypeId = status.Where(a => a.Name == "Free").FirstOrDefault().Id;

            if (bookingDetail != null)
            {
                if (bookingDetail.StatusTypeId == 2)
                {
                    retVal.StatusType = status.Where(a => a.Name == "Booked").FirstOrDefault();
                    retVal.StatusTypeId = status.Where(a => a.Name == "Booked").FirstOrDefault().Id;
                    retVal.BookingFromDate = bookingDetail.BookingFromDate;
                    retVal.BookingToDate = bookingDetail.BookingToDate;
                }
            }

            return retVal;
        }

        public async Task<DeskDetailDTO> GetBookedDeskDetailAsync(int bookingId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();
            var statusRepository = unitOfWork.CreateRepository<StatusType>();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>();
            var status = _mapper.Map<List<StatusTypeDTO>>(await statusRepository.Query().ToListAsync(cancellationToken));


            var bookingDetail = await bookingRepository.Query().Include(a => a.Desk).Where(a => a.Id == bookingId).FirstOrDefaultAsync(cancellationToken);

            var retVal = _mapper.Map<DeskDetailDTO>(
               await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail).Include(a => a.StatusType)
               .Where(a => a.Id == bookingDetail.DeskId).FirstOrDefaultAsync(cancellationToken));

            if (retVal is null)
            {
                retVal = new DeskDetailDTO
                {
                    BuildingDetailId = 0,
                    Id = 0,
                    FloorDetailId = 0,
                    LocationDetailId = 0,
                    SeatNumber = string.Empty,
                    StatusTypeId = status.Where(a => a.Name == "Maintenance").FirstOrDefault().Id,
                    StatusType = status.Where(a => a.Name == "Maintenance").FirstOrDefault(),
                    WingDetailId = 0
                };
            }
            retVal.Comments = bookingDetail.Comments;
            retVal.SeatNumber = bookingDetail.Desk.SeatNumber;
            retVal.BookingFromDate = bookingDetail.BookingFromDate;
            retVal.BookingToDate = bookingDetail.BookingToDate;
            retVal.Id = bookingDetail.Id;
            return retVal;
        }

        public async Task<bool> CreateDeskBookingAsync(BookingDetailDTO bookingDetailDTO, CancellationToken cancellationToken)
        {
            if (bookingDetailDTO == null || bookingDetailDTO.DeskId <= 0)
                return false;

            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>(false);
            var statusRepository = unitOfWork.CreateRepository<StatusType>(false);
            var bookedStatus = await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken);
            var existingBooking = await bookingRepository.Query().Where(a => a.DeskId == bookingDetailDTO.DeskId
            && ((a.BookingFromDate.Value.Date >= Convert.ToDateTime(bookingDetailDTO.BookingFromDate) && a.BookingFromDate.Value.Date <= Convert.ToDateTime(bookingDetailDTO.BookingToDate)) ||
                (a.BookingToDate.Value.Date >= Convert.ToDateTime(bookingDetailDTO.BookingFromDate) && a.BookingToDate.Value.Date <= Convert.ToDateTime(bookingDetailDTO.BookingToDate)) ||
                (Convert.ToDateTime(bookingDetailDTO.BookingFromDate) >= a.BookingToDate.Value.Date && Convert.ToDateTime(bookingDetailDTO.BookingFromDate) <= a.BookingToDate.Value.Date) ||
                (Convert.ToDateTime(bookingDetailDTO.BookingToDate) >= a.BookingFromDate.Value.Date && Convert.ToDateTime(bookingDetailDTO.BookingToDate) <= a.BookingToDate.Value.Date))
             && a.StatusTypeId == bookedStatus.Id).FirstOrDefaultAsync(cancellationToken);

            if (existingBooking is null)
            {
                BookingDetail bookingDetail = _mapper.Map<BookingDetail>(bookingDetailDTO);
                bookingDetail.StatusTypeId = bookedStatus?.Id;
                bookingRepository.Add(bookingDetail, 1);
                await unitOfWork.SaveAsync(cancellationToken, true);

                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> IsDeskFreeForBookingAsync(BookingDetailDTO bookingDetailDTO, CancellationToken cancellationToken)
        {
            var isDeskFreeForBooking = true;

            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var statusRepository = unitOfWork.CreateRepository<StatusType>();
            var bookingDetailRepository = unitOfWork.CreateRepository<BookingDetail>();

            var bookedStatus = _mapper.Map<StatusTypeDTO>(await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken));

            var bookingDetail = await bookingDetailRepository.Query().Where(a => a.DeskId == bookingDetailDTO.DeskId
            && ((a.BookingFromDate.Value.Date >= Convert.ToDateTime(bookingDetailDTO.BookingFromDate) && a.BookingFromDate.Value.Date <= Convert.ToDateTime(bookingDetailDTO.BookingToDate)) ||
                (a.BookingToDate.Value.Date >= Convert.ToDateTime(bookingDetailDTO.BookingFromDate) && a.BookingToDate.Value.Date <= Convert.ToDateTime(bookingDetailDTO.BookingToDate)) ||
                (Convert.ToDateTime(bookingDetailDTO.BookingFromDate) >= a.BookingToDate.Value.Date && Convert.ToDateTime(bookingDetailDTO.BookingFromDate) <= a.BookingToDate.Value.Date) ||
                (Convert.ToDateTime(bookingDetailDTO.BookingToDate) >= a.BookingFromDate.Value.Date && Convert.ToDateTime(bookingDetailDTO.BookingToDate) <= a.BookingToDate.Value.Date))
             && a.StatusTypeId == bookedStatus.Id).FirstOrDefaultAsync(cancellationToken);


            if (bookingDetail != null)
            {
                isDeskFreeForBooking = !(bookingDetail.StatusTypeId == 2);
            }

            return isDeskFreeForBooking;
        }
    }

}