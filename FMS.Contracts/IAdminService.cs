using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IAdminService : IBaseService
    {
        Task<List<DeskReportDetailsDTO>> GetCompleteDesksAsync(DeskReportFilterDTO request, CancellationToken cancellationToken);
        Task<List<DeskReportDetailsDTO>> GetCompleteDesksForAllocationAsync(DeskAllocationFilterDTO request, CancellationToken cancellationToken);
        Task<List<BookingDetailDTO>> GetDeptWiseBookingsAsync(DepartmentWiseBookingsFilterDTO requestDTO, CancellationToken cancellationToken);
        Task<List<BookingDetailDTO>> GetAllCancelledBookingsAsync(DeskReportFilterDTO requestDTO, CancellationToken cancellationToken);
        Task<bool> BulkBookingAsync(List<BulkBookingDetailDTO> request, CancellationToken cancellationToken);
        Task<bool> BulkCancelBookingAsync(List<BulkBookingDetailDTO> request, CancellationToken cancellationToken);
        Task<bool> BlockSeatAsync(BulkDeskBlockDTO request, string comments, CancellationToken cancellationToken);
        Task<bool> AllocateDeskToDeptAsync(List<DeskAllocateDetailDTO> request, CancellationToken cancellationToken);
        Task<bool> DeAllocateDeskFromDeptAsync(List<int> deskIds, int userId, CancellationToken cancellationToken);
        Task<List<DeskAllocateDetailDTO>> GetAllocatedDesksToDeptAsync(CancellationToken cancellationToken);
        Task<bool> BookSeatOnBehalfOfUserAsync(BookingDetailDTO request, CancellationToken cancellationToken);
        Task<bool> CancelBookingOnBehalfOfUserAsync(BookingDetailDTO request, CancellationToken cancellationToken);
        Task<List<string>> GetOtherDepartmentOrTeamNameAsync(CancellationToken cancellationToken);
        Task<bool> CreateAdminConfigurationAsync(int userId, AdminConfigurationDTO request, CancellationToken cancellationToken);
        Task<bool> UpdateAdminConfigurationAsync(int userId, AdminConfigurationDTO request, CancellationToken cancellationToken);
        Task<List<AdminConfigurationDTO>> GetAdminConfigurationAsync(int userId, CancellationToken cancellationToken);
        Task<bool> AddPhotoDetailsAsync(PhotoDetailsDTO photoDetailsDTO, CancellationToken cancellationToken);
        Task<bool> UpdatePhotoDetailsAsync(PhotoDetailsDTO photoDetailsDTO, CancellationToken cancellationToken);
        Task<bool> DeletePhotoDetailsAsync(List<PhotoDetailsDTO> photoDetailsDTOs, int userId, CancellationToken cancellationToken);
        Task<List<PhotoTypeDTO>> GetPhotoTypesAsync(CancellationToken cancellationToken);
        Task<List<PhotoDetailsDTO>> GetDashboardGalleryPhotosAsync(CancellationToken cancellationToken);
        Task<List<PhotoDetailsDTO>> GetAllPhotoDetailsAsync(CancellationToken cancellationToken);
        Task<List<LocationWiseDeskCountDTO>> GetLocationWiseDeskCountAsync(CancellationToken cancellationToken);

    }
}
