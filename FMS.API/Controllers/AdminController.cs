using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Core.Common.Contracts.Configuration;
using FMS.Entities.DTOs;
using FMS.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.API.Controllers
{

    [Authorize]
    public class AdminController : BaseArgsController
    {
        private readonly IAdminService _adminService;
        private readonly IDeskService _deskService;
        private readonly EmailSender _emailSender;
        private readonly IUserService _userService;
        private readonly ApplicationSettings _applicationSettings;
        public AdminController(IRequestContextService requestContextService,
            IAdminService AdminService,
            IDeskService deskService, IUserService userService, ApplicationSettings applicationSettings) : base(requestContextService)
        {
            _adminService = AdminService;
            _deskService = deskService;
            _applicationSettings = applicationSettings;
            _userService = userService;
            _emailSender = new EmailSender(_applicationSettings.EmailSettings);
        }

        [HttpPost("[action]")]
        public async Task<List<DeskReportDetailsDTO>> GetCompleteDesks(DeskReportFilterDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var desks = await _adminService.GetCompleteDesksAsync(request, cancellationToken);
            return desks;
        }

        [HttpPost("[action]")]
        public async Task<List<DeskReportDetailsDTO>> GetCompleteDesksForAllocation(DeskAllocationFilterDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var desks = await _adminService.GetCompleteDesksForAllocationAsync(request, cancellationToken);
            return desks;
        }

        [HttpPost("[action]")]
        public async Task<List<BookingDetailDTO>> GetDeptWiseBookings(DepartmentWiseBookingsFilterDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var desks = await _adminService.GetDeptWiseBookingsAsync(request, cancellationToken);
            return desks;
        }

        [HttpPost("[action]")]
        public async Task<List<BookingDetailDTO>> GetAllCancelledBookings(DeskReportFilterDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var desks = await _adminService.GetAllCancelledBookingsAsync(request, cancellationToken);
            return desks;
        }

        [HttpPost("[action]")]
        public async Task<bool> BulkBooking(List<BulkBookingDetailDTO> request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            request.Select(c =>
            {
                c.UserId = args.UserId;
                c.UserId = args.UserId;
                c.BookedByUserId = args.UserId;
                return c;
            }).ToList();

            var retval = await _adminService.BulkBookingAsync(request, cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> BulkCancelBooking(List<BulkBookingDetailDTO> request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            request.Select(c =>
            {
                c.UserId = args.UserId;
                c.UserId = args.UserId;
                c.BookedByUserId = args.UserId;
                c.CancelledByUserId = args.UserId;
                return c;
            }).ToList();

            var retVal = await _adminService.BulkCancelBookingAsync(request, cancellationToken);

            try
            {
                foreach (var booking in request)
                {
                    var desk = await _deskService.GetBookedDeskDetailAsync((int)booking.BookingId, cancellationToken);
                    if (desk.Comments == "Desk booking - By self For self")
                    {
                        var userBooking = await _deskService.GetBookingDetailsAsync((int)booking.BookingId, cancellationToken);
                        var userDetails = await _userService.GetUserDetailsAsync((int)userBooking.BookedByUserId, cancellationToken);

                        var bodyMsg = "<h3>Dear " + userDetails.FullName + ",<br><br>Admin team has cancelled your booking for Desk# " + desk.SeatNumber + " from " + userBooking.BookingFromDate.Value.ToShortDateString() + " to " + userBooking.BookingToDate.Value.ToShortDateString() + ".<br><br>You can book another desk.<br><br>Thanks & regards,<br>Team Admin.</h3>";
                        await _emailSender.SendEmailAsync(new List<string> { userDetails.CompanyEmailId }, new List<string> { "" }, "Booking Cancelled", bodyMsg);
                    }
                }
            }
            catch (Exception exception1)
            {
                return retVal;
            }
            return retVal;
        }

        [HttpPost("[action]")]
        public async Task<bool> BlockSeat(BulkDeskBlockDTO request, string comments, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;


            var retval = await _adminService.BlockSeatAsync(request, comments, cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> AllocateDeskToDept(List<DeskAllocateDetailDTO> deskAllocateDetails, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            foreach (var detail in deskAllocateDetails)
            {
                detail.AllocatedByUserId = args.UserId;
            }

            var retval = await _adminService.AllocateDeskToDeptAsync(deskAllocateDetails, cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<List<DeskAllocateDetailDTO>> GetAllocatedDesksToDeptAsync(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _adminService.GetAllocatedDesksToDeptAsync(cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> DeAllocateDeskFromDept(List<int> deskIds, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var retval = await _adminService.DeAllocateDeskFromDeptAsync(deskIds, args.UserId, cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> BookSeatOnBehalfOfUser(BookingDetailDTO bookingDetailDTO, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var retval = await _adminService.BookSeatOnBehalfOfUserAsync(bookingDetailDTO, cancellationToken);
            return retval;

        }

        [HttpPost("[action]")]
        public async Task<bool> CancelBookingOnBehalfOfUser(BookingDetailDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var retval = await _adminService.CancelBookingOnBehalfOfUserAsync(request, cancellationToken);
            return retval;

        }

        // For autosearch department
        [HttpPost("[action]")]
        public async Task<List<string>> GetOtherDepartmentOrTeamName(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _adminService.GetOtherDepartmentOrTeamNameAsync(cancellationToken);
            return retval;
        }

        // Create admin config from UI
        [HttpPost("[action]")]
        public async Task<bool> CreateAdminConfiguration(AdminConfigurationDTO adminConfigurationDTO, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var retval = await _adminService.CreateAdminConfigurationAsync(args.UserId, adminConfigurationDTO, cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> UpdateAdminConfiguration(AdminConfigurationDTO adminConfigurationDTO, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var retval = await _adminService.UpdateAdminConfigurationAsync(args.UserId, adminConfigurationDTO, cancellationToken);
            return retval;
        }


        [HttpPost("[action]")]
        public async Task<List<AdminConfigurationDTO>> GetAdminConfiguration(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _adminService.GetAdminConfigurationAsync(args.UserId, cancellationToken);
            return retval;
        }


        [HttpPost("[action]")]
        public async Task SendEmailWithAttachment(EmailDTO emailDTO, CancellationToken cancellationToken)
        {
            await _emailSender.SendEmailWithAttachmentAsync(emailDTO);
        }

        [HttpPost("[action]")]
        public async Task<List<PhotoDetailsDTO>> GetDashboardGalleryPhotos(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _adminService.GetDashboardGalleryPhotosAsync(cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<List<PhotoDetailsDTO>> GetAllPhotoDetails(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _adminService.GetAllPhotoDetailsAsync(cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> AddPhotoDetails(PhotoDetailsDTO photoDetailsDTO, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var retval = await _adminService.AddPhotoDetailsAsync(photoDetailsDTO, cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> UpdatePhotoDetails(PhotoDetailsDTO photoDetailsDTO, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var retval = await _adminService.UpdatePhotoDetailsAsync(photoDetailsDTO, cancellationToken);
            return retval;
        }

        [HttpDelete("[action]")]
        public async Task<bool> DeletePhotoDetails(List<PhotoDetailsDTO> photoDetailsDTOs, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            var result = await _adminService.DeletePhotoDetailsAsync(photoDetailsDTOs, args.UserId, cancellationToken);

            return result;
        }

        [HttpPost("[action]")]
        public async Task<List<PhotoTypeDTO>> GetPhotoTypes(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _adminService.GetPhotoTypesAsync(cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<List<LocationWiseDeskCountDTO>> GetLocationWiseDeskCount(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _adminService.GetLocationWiseDeskCountAsync(cancellationToken);
            return retval;
        }
    }
}