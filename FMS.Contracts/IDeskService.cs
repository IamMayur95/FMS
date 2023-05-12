using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IDeskService : IBaseService
    {
        Task<List<BookingDetailDTO>> GetAllDeskBookingsAsync(int userId, CancellationToken cancellationToken);

        Task<BookingDetailDTO> GetBookingDetailsAsync(int bookingId, CancellationToken cancellationToken);

        Task<List<BookingDetailDTO>> GetAllDeskBookingsForAllUsersAsync(CancellationToken cancellationToken);
        Task<List<DeskDetailDTO>> GetAllDesksAsync(SearchDeskRequestDTO request, CancellationToken cancellationToken);

        Task<DeskDetailDTO> GetDeskDetailAsync(GetDeskDetailDTO request, CancellationToken cancellationToken);

        Task<DeskDetailDTO> GetBookedDeskDetailAsync(int bookingId, CancellationToken cancellationToken);

        Task<bool> CancelBookingAsync(BookingDetailDTO request, CancellationToken cancellationToken);

        Task<bool> CreateDeskBookingAsync(BookingDetailDTO request, CancellationToken cancellationToken);

        Task<bool> IsDeskFreeForBookingAsync(BookingDetailDTO request, CancellationToken cancellationToken);

    }
}