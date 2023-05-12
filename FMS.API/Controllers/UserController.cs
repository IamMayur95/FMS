using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Entities.DTOs;
using FMS.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.API.Controllers
{

    [Authorize]
    public class UserController : BaseArgsController
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(IRequestContextService requestContextService, ILogger<UserController> logger, IUserService userService) : base(requestContextService)
        {
            _logger = logger;
            _userService = userService;
        }


        [HttpPost("[action]")]
        public async Task<UserPreferencesDTO> GetUserPreferences(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();
            if (string.IsNullOrEmpty(args.EmployeeId))
            {
                return null;
            }
            var UserPreferences = await _userService.GetUserPreferencesAsync(args.UserId, cancellationToken);
            return UserPreferences;
        }

        [HttpPost("[action]")]
        public async Task<bool> SaveUserPreferences(UserPreferencesDTO request, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return false;

            request.UserId = args.UserId;

            var retval = await _userService.SaveUserPreferencesAsync(request, cancellationToken);
            return retval;
        }

        [HttpPost("[action]")]
        public async Task<List<UserDTO>> GetUsersList(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();
            if (string.IsNullOrEmpty(args.EmployeeId))
            {
                return null;
            }
            var usersList = await _userService.GetUsersListAsync(cancellationToken);
            return usersList;
        }

        [HttpGet("[action]")]
        public async Task<List<PermissionGroupDTO>> GetPermissionGroupsAsync(CancellationToken cancellationToken)
        {
            var permissionGroupDTOs = await _userService.GetPermissionGroupsAsync(cancellationToken);

            return permissionGroupDTOs;
        }

        [HttpGet("[action]")]
        public async Task<List<UserPermissionGroupDTO>> GetUserPermissionGroupsAsync(CancellationToken cancellationToken)
        {
            var userPermissionGroupDTOs = await _userService.GetUserPermissionGroupsAsync(cancellationToken);

            return userPermissionGroupDTOs;
        }

        [HttpPost("[action]")]
        public async Task<UserPermissionGroupDTO> SaveUserPermissionGroup(UserPermissionGroupDTO userPermissionGroupDTO, CancellationToken cancellationToken)
        {
            userPermissionGroupDTO = await _userService.SaveUserPermissionGroupAsync(userPermissionGroupDTO, cancellationToken);

            return userPermissionGroupDTO;
        }

        [HttpPost("[action]")]
        public async Task<UserPermissionGroupDTO> UpdateUserPermissionGroup(UserPermissionGroupDTO userPermissionGroupDTO, CancellationToken cancellationToken)
        {
            userPermissionGroupDTO = await _userService.UpdateUserPermissionGroupAsync(userPermissionGroupDTO, cancellationToken);

            return userPermissionGroupDTO;
        }

        [HttpDelete("[action]")]
        public async Task<bool> DeleteUserPermissionGroup(List<UserPermissionGroupDTO> userPermissionGroupDTOs, CancellationToken cancellationToken)
        {
            var result = await _userService.DeleteUserPermissionGroupAsync(userPermissionGroupDTOs, cancellationToken);

            return result;
        }

        [HttpGet("[action]")]
        public async Task<List<UserPermissionGroupDTO>> GetLoggedInUserPermissionGroups(CancellationToken cancellationToken)
        {

            var args = GetArgsAsync();
            if (string.IsNullOrEmpty(args.EmployeeId))
            {
                return null;
            }

            var result = await _userService.GetLoggedInUserPermissionGroupsAsync(args.UserId, cancellationToken);

            return result;
        }

        [HttpPost("[action]")]
        public async Task<List<string>> GetUsersDepartmentList(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();
            if (string.IsNullOrEmpty(args.EmployeeId))
            {
                return null;
            }
            var usersList = await _userService.GetUsersDepartmentListAsync(cancellationToken);
            return usersList;
        }

        [HttpPost("[action]")]
        public async Task<List<UserContactDetailsDTO>> GetDashboardContactDetails(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var retval = await _userService.GetDashboardContactDetailsAsync(cancellationToken);
            return retval;
        }
    }
}