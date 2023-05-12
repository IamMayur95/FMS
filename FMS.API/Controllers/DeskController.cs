using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Core.Common.Contracts.Api;
using FMS.Core.Common.Contracts.Configuration;
using FMS.Entities.DTOs;
using FMS.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.API.Controllers
{

    [Authorize]
    public class DeskController : BaseArgsController
    {
        private readonly ILogger<DeskController> _logger;
        private readonly IDeskService _deskService;
        private readonly EmailSender _emailSender;
        private readonly ApplicationSettings _applicationSettings;

        public DeskController(IRequestContextService requestContextService, ILogger<DeskController> logger, IDeskService deskService,
            ApplicationSettings applicationSettings) : base(requestContextService)
        {
            _logger = logger;
            _deskService = deskService;
            _applicationSettings = applicationSettings;
            //IOptionsMonitor<EmailSenderSettings> _emailSettings1 = (IOptionsMonitor<EmailSenderSettings>)applicationSettings.EmailSettings;
            _emailSender = new EmailSender(applicationSettings.EmailSettings);
        }


        [HttpPost("[action]")]
        public async Task<List<BookingDetailDTO>> GetAllDeskBookings(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();
            if (string.IsNullOrEmpty(args.EmployeeId))
            {
                return null;
            }
            var bookings = await _deskService.GetAllDeskBookingsAsync(args.UserId, cancellationToken);
            return bookings;
        }

        [HttpPost("[action]")]
        public async Task<List<BookingDetailDTO>> GetAllDeskBookingsForAllUsers(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();
            if (string.IsNullOrEmpty(args.EmployeeId))
            {
                return null;
            }
            var bookings = await _deskService.GetAllDeskBookingsForAllUsersAsync(cancellationToken);
            return bookings;
        }

        [HttpPost("[action]")]
        public async Task<List<DeskDetailDTO>> GetAllDesks(SearchDeskRequestDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var desks = await _deskService.GetAllDesksAsync(request, cancellationToken);
            return desks;
        }

        [HttpPost("[action]")]
        public async Task<DeskDetailDTO> GetDeskDetail(GetDeskDetailDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var desks = await _deskService.GetDeskDetailAsync(request, cancellationToken);
            return desks;
        }

        [HttpPost("[action]")]
        public async Task<DeskDetailDTO> GetBookedDeskDetail(int bookingId, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var desks = await _deskService.GetBookedDeskDetailAsync(bookingId, cancellationToken);
            return desks;
        }

        [HttpPost("[action]")]
        public async Task<bool> CancelBooking(BookingDetailDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            request.UserId = args.UserId;
            request.CancelledByUserId = args.UserId;

            var retVal = await _deskService.CancelBookingAsync(request, cancellationToken);
            try
            {
                var bookedDesk = await _deskService.GetBookedDeskDetailAsync(request.Id.Value, cancellationToken);

                var bodyMsg = "<h3>Dear " + args.FullName + ",<br><br>You have successfully cancelled your booking for Desk# " + bookedDesk.SeatNumber + " from " + request.BookingFromDate.Value.ToShortDateString() + " to " + request.BookingToDate.Value.ToShortDateString() + ".<br><br>Thanks & regards,<br>Team Admin.</h3>";
                await _emailSender.SendEmailAsync(new List<string> { args.Email }, new List<string> { "" }, "Booking Cancelled", bodyMsg);
            }
            catch (Exception exception1)
            {
                return retVal;
            }
            return retVal;
        }

        [HttpPost("[action]")]
        public async Task<bool> IsDeskFreeForBooking(BookingDetailDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            request.UserId = args.UserId;
            request.BookedByUserId = args.UserId;

            var retval = await _deskService.IsDeskFreeForBookingAsync(request, cancellationToken);
            
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<bool> CreateDeskBooking(BookingDetailDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            request.UserId = args.UserId;
            request.BookedByUserId = args.UserId;
            var requestedDesk = request.Desk;
            request.Desk = null;

            var retval = await _deskService.CreateDeskBookingAsync(request, cancellationToken);
            if (retval)

                try
                {
                    var bodyMsg = "<h3>Dear " + args.FullName + ",<br><br>You have successfully booked Desk# " + requestedDesk.SeatNumber + " from " + request.BookingFromDate.Value.ToShortDateString() + " to " + request.BookingToDate.Value.ToShortDateString() + ".<br><br>Thanks & regards,<br>Team Admin.</h3>";
                    await _emailSender.SendEmailAsync(new List<string> { args.Email }, new List<string> { "" }, "Booking Successful", bodyMsg);
                }
                catch (Exception exception1)
                {
                    return retval;
                }
            return retval;
        }
    }
}