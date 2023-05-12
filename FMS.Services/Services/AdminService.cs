using AutoMapper;
using FMS.Contracts;
using FMS.Core.Services;
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

    public class AdminService : BaseAuditableService, IAdminService
    {
        private readonly IMapper _mapper;

        public AdminService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper) : base(unitOfWorkFactory)
        {
            _mapper = mapper;
        }

        public async Task<List<DeskReportDetailsDTO>> GetCompleteDesksAsync(DeskReportFilterDTO requestDTO, CancellationToken cancellationToken)
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

            if (requestDTO.Floor != null && requestDTO.Floor.Id > 0)
            {
                retVal = retVal.Where(a => a.FloorDetailId == requestDTO.Floor.Id).ToList();
            }

            if (requestDTO.Wing != null && requestDTO.Wing.Id > 0)
            {
                retVal = retVal.Where(a => a.WingDetailId == requestDTO.Wing.Id).ToList();
            }
            var completeDestResult = new List<DeskReportDetailsDTO>();
            foreach (DeskDetailDTO item in retVal)
            {
                var bookingForCurrentDesk = bookedSeatsForSelectedDate.Where(b => b.DeskId == item.Id).FirstOrDefault();

                var deskDetails = new DeskReportDetailsDTO()
                {
                    Bookingdetails = bookingForCurrentDesk,
                    BuildingDetail = item.BuildingDetail,
                    BuildingDetailId = item.BuildingDetailId,
                    FloorDetail = item.FloorDetail,
                    FloorDetailId = item.FloorDetailId,
                    Id = item.Id,
                    LocationDetail = item.LocationDetail,
                    LocationDetailId = item.LocationDetailId,
                    Name = item.Name,
                    SeatNumber = item.SeatNumber,
                    Section = item.Section,
                    Status = bookingForCurrentDesk != null && bookingForCurrentDesk.StatusTypeId != 3 ? DeskStatusType.Booked : DeskStatusType.Free,
                    WingDetail = item.WingDetail,
                    WingDetailId = item.WingDetailId
                };

                completeDestResult.Add(deskDetails);
            }

            return completeDestResult.OrderBy(a => a.SeatNumber).ToList();
        }

        public async Task<List<DeskReportDetailsDTO>> GetCompleteDesksForAllocationAsync(DeskAllocationFilterDTO requestDTO, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskDetailRepository = unitOfWork.CreateRepository<DeskDetail>();

            var retVal = _mapper.Map<List<DeskDetailDTO>>(
                await deskDetailRepository.Query().Include(a => a.FloorDetail).Include(a => a.LocationDetail).Include(a => a.WingDetail).Include(a => a.BuildingDetail)
                .Where(a => a.LocationDetailId == requestDTO.Location.Id).ToListAsync(cancellationToken));

            if (requestDTO.Floor != null && requestDTO.Floor.Id > 0)
            {
                retVal = retVal.Where(a => a.FloorDetailId == requestDTO.Floor.Id).ToList();
            }

            if (requestDTO.Wing != null && requestDTO.Wing.Id > 0)
            {
                retVal = retVal.Where(a => a.WingDetailId == requestDTO.Wing.Id).ToList();
            }

            var completeDestResult = new List<DeskReportDetailsDTO>();
            foreach (DeskDetailDTO item in retVal)
            {
                var deskDetails = new DeskReportDetailsDTO()
                {
                    Bookingdetails = new BookingDetail(),
                    BuildingDetail = item.BuildingDetail,
                    BuildingDetailId = item.BuildingDetailId,
                    FloorDetail = item.FloorDetail,
                    FloorDetailId = item.FloorDetailId,
                    Id = item.Id,
                    LocationDetail = item.LocationDetail,
                    LocationDetailId = item.LocationDetailId,
                    Name = item.Name,
                    SeatNumber = item.SeatNumber,
                    Section = item.Section,
                    Status = DeskStatusType.Free,
                    WingDetail = item.WingDetail,
                    WingDetailId = item.WingDetailId
                };

                completeDestResult.Add(deskDetails);
            }

            return completeDestResult.OrderBy(a => a.SeatNumber).ToList();
        }

        public async Task<List<BookingDetailDTO>> GetDeptWiseBookingsAsync(DepartmentWiseBookingsFilterDTO requestDTO, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>();
            var statusRepository = unitOfWork.CreateRepository<StatusType>();

            var status = _mapper.Map<StatusTypeDTO>(await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken));

            var retVal = _mapper.Map<List<BookingDetailDTO>>(
                await bookingRepository.Query().Include(a => a.BookedByUser).Include(a => a.CancelledByUser).Include(a => a.Desk).Include(a => a.Desk.LocationDetail)
                .Include(a => a.Desk.BuildingDetail).Include(a => a.Desk.FloorDetail).Include(a => a.Desk.WingDetail).Include(a => a.StatusType)
                .Where(a => a.DeskId > 0).Where(a => a.Desk.LocationDetailId == requestDTO.Location.Id)
                .Where(a => a.Desk.FloorDetailId == requestDTO.Floor.Id)
                .Where(a => a.Desk.WingDetailId == requestDTO.Wing.Id)
                .Where(a => a.BookedByUser.Department == requestDTO.Department)
                .ToListAsync(cancellationToken));

            var retData = retVal.Where(a => ((a.BookingFromDate.Value.Date >= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingFromDate.Value.Date <= Convert.ToDateTime(requestDTO.ToDate))

                    || (a.BookingToDate.Value.Date >= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingToDate.Value.Date <= Convert.ToDateTime(requestDTO.ToDate))

                    || (a.BookingFromDate.Value.Date <= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingToDate.Value.Date >= Convert.ToDateTime(requestDTO.ToDate))) &&

                    a.StatusTypeId == status.Id);

            return retData.OrderByDescending(a => a.Id).ToList();
        }

        public async Task<List<BookingDetailDTO>> GetAllCancelledBookingsAsync(DeskReportFilterDTO requestDTO, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>();
            var statusRepository = unitOfWork.CreateRepository<StatusType>();

            var status = _mapper.Map<StatusTypeDTO>(await statusRepository.Query().Where(a => a.Name == "Cancelled").FirstOrDefaultAsync(cancellationToken));

            var retVal = _mapper.Map<List<BookingDetailDTO>>(
                await bookingRepository.Query().Include(a => a.BookedByUser).Include(a => a.CancelledByUser).Include(a => a.Desk).Include(a => a.Desk.LocationDetail)
                .Include(a => a.Desk.BuildingDetail).Include(a => a.Desk.FloorDetail).Include(a => a.Desk.WingDetail).Include(a => a.StatusType)
                .Where(a => a.DeskId > 0).Where(a => a.Desk.LocationDetailId == requestDTO.Location.Id)
                .Where(a => a.Desk.FloorDetailId == requestDTO.Floor.Id)
                .Where(a => a.Desk.WingDetailId == requestDTO.Wing.Id)
                .ToListAsync(cancellationToken));

            var retData = retVal.Where(a => ((a.BookingFromDate.Value.Date >= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingFromDate.Value.Date <= Convert.ToDateTime(requestDTO.ToDate))

                    || (a.BookingToDate.Value.Date >= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingToDate.Value.Date <= Convert.ToDateTime(requestDTO.ToDate))

                    || (a.BookingFromDate.Value.Date <= Convert.ToDateTime(requestDTO.FromDate)
                    && a.BookingToDate.Value.Date >= Convert.ToDateTime(requestDTO.ToDate))) &&

                    a.StatusTypeId == status.Id);

            return retData.OrderByDescending(a => a.Id).ToList();
        }

        public async Task<bool> BulkBookingAsync(List<BulkBookingDetailDTO> bulkBookingDetailDTO, CancellationToken cancellationToken)
        {
            if (bulkBookingDetailDTO == null || bulkBookingDetailDTO.Count() <= 0)
                return false;

            foreach (var desk in bulkBookingDetailDTO)
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();
                var bookingRepository = unitOfWork.CreateRepository<BookingDetail>(false);
                var statusRepository = unitOfWork.CreateRepository<StatusType>(false);
                var bookedStatus = await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken);

                //    var existingBooking = await bookingRepository.Query().Where(a => a.DeskId == deskId
                //&& DateTime.Compare(a.BookingFromDate.Value.Date, DateTime.UtcNow.Date) == 0).FirstOrDefaultAsync(cancellationToken);

                var existingBooking = await bookingRepository.Query().Where(a => a.DeskId == desk.DeskId
            && ((a.BookingFromDate.Value.Date >= Convert.ToDateTime(desk.BookingFromDate) && a.BookingFromDate.Value.Date <= Convert.ToDateTime(desk.BookingToDate)) ||
                (a.BookingToDate.Value.Date >= Convert.ToDateTime(desk.BookingFromDate) && a.BookingToDate.Value.Date <= Convert.ToDateTime(desk.BookingToDate)) ||
                (Convert.ToDateTime(desk.BookingFromDate) >= a.BookingToDate.Value.Date && Convert.ToDateTime(desk.BookingFromDate) <= a.BookingToDate.Value.Date) ||
                (Convert.ToDateTime(desk.BookingToDate) >= a.BookingFromDate.Value.Date && Convert.ToDateTime(desk.BookingToDate) <= a.BookingToDate.Value.Date))
             && a.StatusTypeId == bookedStatus.Id).FirstOrDefaultAsync(cancellationToken);

                if (existingBooking is null)
                {
                    var booking = new BookingDetail()
                    {
                        UserId = desk.UserId,
                        DeskId = desk.DeskId,
                        BookingFromDate = desk.BookingFromDate,
                        BookingToDate = desk.BookingToDate,
                        BookedByUserId = desk.BookedByUserId,
                        BookingType = FMSBookingType.Desk,
                        Comments = desk.Comments,
                        StatusTypeId = bookedStatus?.Id
                    };

                    bookingRepository.Add(booking, 1);
                    await unitOfWork.SaveAsync(cancellationToken, true);
                }
            }
            return true;
        }

        public async Task<bool> BulkCancelBookingAsync(List<BulkBookingDetailDTO> bulkBookingDetailDTO, CancellationToken cancellationToken)
        {
            if (bulkBookingDetailDTO == null || bulkBookingDetailDTO.Count() <= 0)
                return false;

            foreach (var booking in bulkBookingDetailDTO)
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();
                var bookingRepository = unitOfWork.CreateRepository<BookingDetail>(false);
                var statusRepository = unitOfWork.CreateRepository<StatusType>();

                var bookedStatus = await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken);
                var cancelStatus = await statusRepository.Query().Where(a => a.Name == "Cancelled").FirstOrDefaultAsync(cancellationToken);

                var bookingDetail = await bookingRepository.Query().Where(a => a.Id == booking.BookingId).FirstOrDefaultAsync(cancellationToken);

                if (bookingDetail is not null)
                {
                    bookingDetail.StatusTypeId = cancelStatus.Id;
                    bookingDetail.CancelledByUserId = booking.UserId;
                    bookingDetail.CancelledDate = booking.CancelledDate;
                    //bookingDetail.Comments = "Desk booking cancellation - by Admin";
                }
                await bookingRepository.Update(bookingDetail, 1, cancellationToken);
                await unitOfWork.SaveAsync(cancellationToken);
            }
            return true;
        }

        public async Task<bool> BlockSeatAsync(BulkDeskBlockDTO bulkDeskBlockDTO, string comments, CancellationToken cancellationToken)
        {
            if (bulkDeskBlockDTO.DeskIds.Count <= 0)
                return false;

            foreach (var deskId in bulkDeskBlockDTO.DeskIds)
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();
                var deskRepository = unitOfWork.CreateRepository<DeskDetail>(false);
                var desk = await deskRepository.Query().Where(a => a.Id == deskId).FirstOrDefaultAsync(cancellationToken);

                if (desk is not null)
                {
                    desk.IsBlockedSeat = true;
                    desk.Comments = comments;

                    await unitOfWork.SaveAsync(cancellationToken, true);
                }
            }
            return true;
        }


        // Admin can allocate seat for dept and for super admin so only super admin can consume it.
        public async Task<bool> AllocateDeskToDeptAsync(List<DeskAllocateDetailDTO> deskAllocateDetails, CancellationToken cancellationToken)
        {
            try
            {
                if (deskAllocateDetails.Count <= 0)
                    return false;

                foreach (var deskAllocateDetail in deskAllocateDetails)
                {
                    using var unitOfWork = UnitOfWorkFactory.GetInstance();
                    var deskAllocateDetailRepository = unitOfWork.CreateRepository<DeskAllocateDetail>(false);
                    var desk = await deskAllocateDetailRepository.Query().Where(a => a.DeskId == deskAllocateDetail.DeskId).FirstOrDefaultAsync(cancellationToken);

                    if (desk is null)
                    {
                        DeskAllocateDetail deskDetail = _mapper.Map<DeskAllocateDetail>(deskAllocateDetail);
                        deskAllocateDetailRepository.Add(deskDetail, 1);
                        await unitOfWork.SaveAsync(cancellationToken, true);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeAllocateDeskFromDeptAsync(List<int> deskIds, int userId, CancellationToken cancellationToken)
        {
            var result = false;
            try
            {
                if (deskIds.Count <= 0)
                    return false;

                foreach (var deskId in deskIds)
                {
                    using var unitOfWork = UnitOfWorkFactory.GetInstance();
                    var deskAllocateDetailRepository = unitOfWork.CreateRepository<DeskAllocateDetail>(false);
                    var desk = await deskAllocateDetailRepository.Query().Where(a => a.DeskId == deskId).FirstOrDefaultAsync(cancellationToken);

                    if (desk is not null)
                    {
                        DeskAllocateDetail deskDetail = _mapper.Map<DeskAllocateDetail>(desk);
                        await deskAllocateDetailRepository.Remove(deskDetail.Id, userId, cancellationToken);
                        result = await unitOfWork.SaveAsync(cancellationToken, true) > 0;
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<List<DeskAllocateDetailDTO>> GetAllocatedDesksToDeptAsync(CancellationToken cancellationToken)
        {
            try
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();
                var deskAllocateDetailRepository = unitOfWork.CreateRepository<DeskAllocateDetail>(false);
                var allocatedDesks = await deskAllocateDetailRepository.Query().Include(a => a.AllocatedByUser).ToListAsync(cancellationToken);

                return _mapper.Map<List<DeskAllocateDetailDTO>>(allocatedDesks);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<bool> BookSeatOnBehalfOfUserAsync(BookingDetailDTO bookingDetailDTO, CancellationToken cancellationToken)
        {
            if (bookingDetailDTO == null || bookingDetailDTO.DeskId <= 0)
                return false;

            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>(false);
            var statusRepository = unitOfWork.CreateRepository<StatusType>(false);
            var bookedStatus = await statusRepository.Query().Where(a => a.Name == "Booked").FirstOrDefaultAsync(cancellationToken);
            var existingBooking = await bookingRepository.Query().Where(a => a.DeskId == bookingDetailDTO.DeskId
            && a.BookingFromDate.Value.Date <= Convert.ToDateTime(bookingDetailDTO.BookingFromDate) &&
             Convert.ToDateTime(bookingDetailDTO.BookingToDate) <= a.BookingToDate.Value.Date && a.StatusTypeId == bookedStatus.Id).FirstOrDefaultAsync(cancellationToken);

            if (existingBooking is null)
            {
                BookingDetail bookingDetail = _mapper.Map<BookingDetail>(bookingDetailDTO);
                bookingDetail.StatusTypeId = bookedStatus?.Id;
                bookingRepository.Add(bookingDetail, 1);
                await unitOfWork.SaveAsync(cancellationToken, true);
            }
            return true;

        }

        public async Task<bool> CancelBookingOnBehalfOfUserAsync(BookingDetailDTO request, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var bookingRepository = unitOfWork.CreateRepository<BookingDetail>(false);
            var statusRepository = unitOfWork.CreateRepository<StatusType>();

            var status = _mapper.Map<List<StatusTypeDTO>>(await statusRepository.Query().ToListAsync(cancellationToken));

            var bookingDetail = await bookingRepository.Query().Where(a => a.Id == request.Id).FirstOrDefaultAsync(cancellationToken);
            if (bookingDetail is not null)
            {
                bookingDetail.StatusTypeId = status.Where(a => a.Name == "Cancelled").FirstOrDefault()?.Id;
            }
            await unitOfWork.SaveAsync(cancellationToken);
            return true;

        }

        // For autosearch department
        public async Task<List<string>> GetOtherDepartmentOrTeamNameAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var deskAllocateDetailRepository = unitOfWork.CreateRepository<DeskAllocateDetail>(false);

            var departmentList = _mapper.Map<List<string>>(await deskAllocateDetailRepository.Query().Select(o => o.Department).Distinct().ToListAsync(cancellationToken));
            return departmentList;
        }

        // Create admin config from UI
        public async Task<bool> CreateAdminConfigurationAsync(int userId, AdminConfigurationDTO adminConfigurationDTO, CancellationToken cancellationToken)
        {

            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var adminConfigurationRepository = unitOfWork.CreateRepository<AdminConfiguration>(false);
            var config = await adminConfigurationRepository.Query().Where(a => a.Key == adminConfigurationDTO.Key).FirstOrDefaultAsync(cancellationToken);

            if (config is null)
            {
                AdminConfiguration adminConfiguration = _mapper.Map<AdminConfiguration>(adminConfigurationDTO);
                adminConfigurationRepository.Add(adminConfiguration, 1);
                await unitOfWork.SaveAsync(cancellationToken, true);
            }

            return true;
        }

        // Get admin config
        public async Task<List<AdminConfigurationDTO>> GetAdminConfigurationAsync(int userId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var adminConfigurationRepository = unitOfWork.CreateRepository<AdminConfiguration>(false);

            var retVal = _mapper.Map<List<AdminConfigurationDTO>>(
                await adminConfigurationRepository.Query().ToListAsync(cancellationToken));

            return retVal.ToList();
        }

        // Get admin config
        public async Task<bool> UpdateAdminConfigurationAsync(int userId, AdminConfigurationDTO adminConfigurationDTO, CancellationToken cancellationToken)
        {
            var result = false;

            try
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();
                var adminConfigurationRepository = unitOfWork.CreateRepository<AdminConfiguration>(false);
                var config = await adminConfigurationRepository.Query().Where(a => a.Key == adminConfigurationDTO.Key).FirstOrDefaultAsync(cancellationToken);

                if (config is not null)
                {
                    config.Value = adminConfigurationDTO.Value;
                    AdminConfiguration adminConfiguration = _mapper.Map<AdminConfiguration>(config);
                    await adminConfigurationRepository.Update(adminConfiguration, 1, cancellationToken);
                    await unitOfWork.SaveAsync(cancellationToken, true);
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                return result;
            }
        }

        public async Task<List<PhotoDetailsDTO>> GetDashboardGalleryPhotosAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var photoDetailsRepository = unitOfWork.CreateRepository<PhotoDetails>(false);

            var photoTypeRepository = unitOfWork.CreateRepository<PhotoType>(false);
            var dashboardGallaryType = _mapper.Map<PhotoType>(await photoTypeRepository.Query().Where(a => a.Name == "Dashboard Carousel").FirstOrDefaultAsync(cancellationToken));

            var retVal = _mapper.Map<List<PhotoDetailsDTO>>(await photoDetailsRepository.Query().Where(a => a.Type == dashboardGallaryType.Id).ToListAsync(cancellationToken));
            return retVal.ToList();
        }

        public async Task<List<PhotoDetailsDTO>> GetAllPhotoDetailsAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var photoDetailsRepository = unitOfWork.CreateRepository<PhotoDetails>(false);

            var locationRepository = unitOfWork.CreateRepository<LocationDetail>(false);
            var floorRepository = unitOfWork.CreateRepository<FloorDetail>(false);
            var wingRepository = unitOfWork.CreateRepository<WingDetail>(false);

            var retVal = _mapper.Map<List<PhotoDetailsDTO>>(await photoDetailsRepository.Query().ToListAsync(cancellationToken));

            foreach (var photoDetail in retVal)
            {
                if (photoDetail.LocationId != null)
                {
                    var locationDetails = await locationRepository.Query().Where(a => a.Id == photoDetail.LocationId).FirstOrDefaultAsync(cancellationToken);
                    var floorDetails = await floorRepository.Query().Where(a => a.Id == photoDetail.FloorId).FirstOrDefaultAsync(cancellationToken);
                    var wingDetails = await wingRepository.Query().Where(a => a.Id == photoDetail.WingId).FirstOrDefaultAsync(cancellationToken);

                    photoDetail.LocationDetail = locationDetails;
                    photoDetail.FloorDetail = floorDetails;
                    photoDetail.WingDetail = wingDetails;
                }
            }

            return retVal.ToList();
        }

        public async Task<bool> AddPhotoDetailsAsync(PhotoDetailsDTO photoDetailsDTO, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var photoDetailsRepository = unitOfWork.CreateRepository<PhotoDetails>(false);

            var photoTypeRepository = unitOfWork.CreateRepository<PhotoType>(false);

            if (photoDetailsDTO != null)
            {
                PhotoDetails photoDetails = _mapper.Map<PhotoDetails>(photoDetailsDTO);

                var photoType = photoTypeRepository.Query().FirstOrDefault(pType => pType.Id == photoDetails.Type);
                photoDetails.PhotoType = photoType;

                photoDetailsRepository.Add(photoDetails, 1);
                await unitOfWork.SaveAsync(cancellationToken, true);
            }

            return true;
        }

        public async Task<bool> UpdatePhotoDetailsAsync(PhotoDetailsDTO photoDetailsDTO, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var photoDetailsRepository = unitOfWork.CreateRepository<PhotoDetails>(false);
            var existingPhotoDetails = await photoDetailsRepository.Query().Where(a => a.Id == photoDetailsDTO.Id).FirstOrDefaultAsync(cancellationToken);

            if (existingPhotoDetails is not null)
            {
                existingPhotoDetails.Title = photoDetailsDTO.Title;
                existingPhotoDetails.Type = photoDetailsDTO.Type;
                existingPhotoDetails.Description = photoDetailsDTO.Description;

                existingPhotoDetails.ImageData = photoDetailsDTO.ImageData;
                existingPhotoDetails.OtherDetails = photoDetailsDTO.OtherDetails;
                existingPhotoDetails.MetaKeys = photoDetailsDTO.MetaKeys;
                existingPhotoDetails.Date = photoDetailsDTO.Date;

                existingPhotoDetails.LocationId = photoDetailsDTO.LocationId;
                existingPhotoDetails.FloorId = photoDetailsDTO.FloorId;
                existingPhotoDetails.WingId = photoDetailsDTO.WingId;

                PhotoDetails updatedPhotoDetails = _mapper.Map<PhotoDetails>(existingPhotoDetails);
                await photoDetailsRepository.Update(updatedPhotoDetails, 1, cancellationToken);
                await unitOfWork.SaveAsync(cancellationToken, true);
            }

            return true;
        }

        public async Task<bool> DeletePhotoDetailsAsync(List<PhotoDetailsDTO> photoDetailsDTOs, int userId, CancellationToken cancellationToken)
        {
            var result = false;
            try
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();

                var photoDetailsRepository = unitOfWork.CreateRepository<PhotoDetails>(false);

                foreach (var photoDetailsDTO in photoDetailsDTOs)
                {
                    if (photoDetailsDTO.Id > 0)
                    {
                        var existingPhotoDetail = _mapper.Map<List<PhotoDetailsDTO>>(await photoDetailsRepository.Query().Where(item => item.Id == photoDetailsDTO.Id).ToListAsync(cancellationToken));

                        if (existingPhotoDetail.Count > 0)
                        {
                            PhotoDetails PhotoDetail = _mapper.Map<PhotoDetails>(existingPhotoDetail[0]);
                            await photoDetailsRepository.Remove(PhotoDetail.Id, userId, cancellationToken);
                        }
                    }
                }
                await unitOfWork.SaveAsync(cancellationToken, true);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<PhotoTypeDTO>> GetPhotoTypesAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var photoTypeRepository = unitOfWork.CreateRepository<PhotoType>(false);

            var retVal = _mapper.Map<List<PhotoTypeDTO>>(
                await photoTypeRepository.Query().ToListAsync(cancellationToken));

            return retVal.ToList();
        }

        public async Task<List<LocationWiseDeskCountDTO>> GetLocationWiseDeskCountAsync(CancellationToken cancellationToken)
        {
            return new List<LocationWiseDeskCountDTO>()
            {
                new LocationWiseDeskCountDTO()
                {
                    Location = "Pune",
                    Id = 1,
                    FreeDeskCount = 150,
                    BookedDeskCount = 300,
                    MaintenanceDeskCount = 20
                },
                new LocationWiseDeskCountDTO()
                {
                    Location = "Bangalore",
                    Id = 1,
                    FreeDeskCount = 120,
                    BookedDeskCount = 150,
                    MaintenanceDeskCount = 15
                }
            };
        }

    }

}
