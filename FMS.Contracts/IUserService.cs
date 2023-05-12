using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IUserService : IBaseService
    {
        Task<UserPreferencesDTO> GetUserPreferencesAsync(int userId, CancellationToken cancellationToken);

        Task<bool> SaveUserPreferencesAsync(UserPreferencesDTO request, CancellationToken cancellationToken);

        Task<List<UserDTO>> GetUsersListAsync(CancellationToken cancellationToken);

        Task<UserDTO> GetUserDetailsAsync(int userId, CancellationToken cancellationToken);

        Task<List<PermissionGroupDTO>> GetPermissionGroupsAsync(CancellationToken cancellationToken);

        Task<List<UserPermissionGroupDTO>> GetUserPermissionGroupsAsync(CancellationToken cancellationToken);

        Task<UserPermissionGroupDTO> SaveUserPermissionGroupAsync(UserPermissionGroupDTO userPermissionGroupDTO, CancellationToken cancellationToken);

        Task<UserPermissionGroupDTO> UpdateUserPermissionGroupAsync(UserPermissionGroupDTO userPermissionGroupDTO, CancellationToken cancellationToken);

        Task<bool> DeleteUserPermissionGroupAsync(List<UserPermissionGroupDTO> userPermissionGroupDTO, CancellationToken cancellationToken);

        Task<List<UserPermissionGroupDTO>> GetLoggedInUserPermissionGroupsAsync(int userId, CancellationToken cancellationToken);

        Task<List<string>> GetUsersDepartmentListAsync(CancellationToken cancellationToken);

        Task<List<UserContactDetailsDTO>> GetDashboardContactDetailsAsync(CancellationToken cancellationToken);
    }
}