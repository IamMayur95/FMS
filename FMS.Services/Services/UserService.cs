using AutoMapper;
using FMS.Contracts;
using FMS.Core.Services;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using FMS.Entities.Models.Enums;
using FMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Services.Services
{

    public class UserService : BaseAuditableService, IUserService
    {
        private readonly IMapper _mapper;

        public UserService(IUnitOfWorkFactory unitOfWorkFactory, IMapper mapper) : base(unitOfWorkFactory)
        {
            _mapper = mapper;
        }

        public async Task<UserPreferencesDTO> GetUserPreferencesAsync(int userId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var userPreferencesRepository = unitOfWork.CreateRepository<UserPreference>();

            var userPreference = _mapper.Map<UserPreferencesDTO>(await userPreferencesRepository.Query()
                .Where(a => a.UserId == userId)
                .Where(a => a.UserPreferenceType == UserPreferenceType.FindDesk)
                .FirstOrDefaultAsync(cancellationToken));

            return userPreference;
        }

        public async Task<bool> SaveUserPreferencesAsync(UserPreferencesDTO userPreferencesDTO, CancellationToken cancellationToken)
        {
            if (userPreferencesDTO == null)
                return false;

            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var userPreferencesRepository = unitOfWork.CreateRepository<UserPreference>(false);

            var userPreference = await userPreferencesRepository.Query()
                .Where(a => a.UserId == userPreferencesDTO.UserId)
                .Where(a => a.UserPreferenceType == userPreferencesDTO.UserPreferenceType)
                .FirstOrDefaultAsync(cancellationToken);

            if (userPreference is null)
            {
                UserPreference preference = _mapper.Map<UserPreference>(userPreferencesDTO);
                userPreferencesRepository.Add(preference, userPreferencesDTO.UserId ?? default(int));
                await unitOfWork.SaveAsync(cancellationToken);
            }
            else
            {
                userPreference.LocationDetailId = userPreferencesDTO.LocationDetailId;
                userPreference.FloorDetailId = userPreferencesDTO.FloorDetailId;
                userPreference.WingDetailId = userPreferencesDTO.WingDetailId;

                UserPreference userPreferences = _mapper.Map<UserPreference>(userPreference);
                await userPreferencesRepository.Update(userPreferences, 1, cancellationToken);
                await unitOfWork.SaveAsync(cancellationToken);

            }

            return true;
        }

        public async Task<List<UserDTO>> GetUsersListAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var userRepository = unitOfWork.CreateRepository<User>(false);

            var usersList = _mapper.Map<List<UserDTO>>(await userRepository.Query().ToListAsync(cancellationToken));
            return usersList;
        }

        public async Task<UserDTO> GetUserDetailsAsync(int userId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var userRepository = unitOfWork.CreateRepository<User>(false);

            var userDetail = _mapper.Map<UserDTO>(await userRepository.Query().Where(user => user.Id == userId).FirstOrDefaultAsync(cancellationToken));
            return userDetail;
        }

        public async Task<List<PermissionGroupDTO>> GetPermissionGroupsAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var permissionGroupRepository = unitOfWork.CreateRepository<PermissionGroup>(false);

            var permissionGroupList = _mapper.Map<List<PermissionGroupDTO>>(await permissionGroupRepository.Query().ToListAsync(cancellationToken));
            return permissionGroupList;
        }

        public async Task<UserPermissionGroupDTO> SaveUserPermissionGroupAsync(UserPermissionGroupDTO userPermissionGroupDTO, CancellationToken cancellationToken)
        {
            if (userPermissionGroupDTO == null)
                return null;

            using var unitOfWork = UnitOfWorkFactory.GetInstance();

            var userPermissionGroupRepository = unitOfWork.CreateRepository<UserPermissionGroup>(false);

            UserPermissionGroup userPermissionGroup = null;

            userPermissionGroup = new UserPermissionGroup
            {
                PermissionGroupId = userPermissionGroupDTO.PermissionGroupId,
                UserId = userPermissionGroupDTO.UserId,
                PhoneNumber = userPermissionGroupDTO.PhoneNumber,
            };

            userPermissionGroupRepository.Add(userPermissionGroup, userPermissionGroup.UserId);
            await unitOfWork.SaveAsync(cancellationToken);

            userPermissionGroupDTO = _mapper.Map<UserPermissionGroupDTO>(userPermissionGroup);
            return await Task.FromResult(userPermissionGroupDTO);
        }
        public async Task<UserPermissionGroupDTO> UpdateUserPermissionGroupAsync(UserPermissionGroupDTO userPermissionGroupDTO, CancellationToken cancellationToken)
        {
            if (userPermissionGroupDTO == null)
                return null;

            using var unitOfWork = UnitOfWorkFactory.GetInstance();

            var userPermissionGroupRepository = unitOfWork.CreateRepository<UserPermissionGroup>(false);

            UserPermissionGroup userPermissionGroup = null;

            if (userPermissionGroupDTO.Id > 0)
            {
                userPermissionGroup = userPermissionGroupRepository.Query().FirstOrDefault(item => item.UserId == userPermissionGroupDTO.UserId);

                if (userPermissionGroup is not null)
                {
                    userPermissionGroup.PermissionGroupId = userPermissionGroupDTO.PermissionGroupId;
                    userPermissionGroup.PhoneNumber = userPermissionGroupDTO.PhoneNumber;
                }

                await userPermissionGroupRepository.Update(userPermissionGroup, 1, cancellationToken);
                await unitOfWork.SaveAsync(cancellationToken);
            }

            userPermissionGroupDTO = _mapper.Map<UserPermissionGroupDTO>(userPermissionGroup);
            return await Task.FromResult(userPermissionGroupDTO);
        }

        public async Task<bool> DeleteUserPermissionGroupAsync(List<UserPermissionGroupDTO> userPermissionGroupDTOs, CancellationToken cancellationToken)
        {
            var result = false;
            try
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();

                var userPermissionGroupRepository = unitOfWork.CreateRepository<UserPermissionGroup>(false);

                foreach (var userPermissionGroupDTO in userPermissionGroupDTOs)
                {
                    if (userPermissionGroupDTO.Id > 0)
                    {
                        var userPermissionGroup = userPermissionGroupRepository.Query().FirstOrDefault(item => item.Id == userPermissionGroupDTO.Id);

                        if (userPermissionGroup is not null)
                        {
                            await userPermissionGroupRepository.Remove(userPermissionGroup.Id, userPermissionGroup.UserId, cancellationToken);
                        }
                    }
                }
                await unitOfWork.SaveAsync(cancellationToken);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public async Task<List<UserPermissionGroupDTO>> GetUserPermissionGroupsAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();

            var userPermissionGroupRepository = unitOfWork.CreateRepository<UserPermissionGroup>(false);
            var userRepository = unitOfWork.CreateRepository<User>(true);
            var permissionGroupRepository = unitOfWork.CreateRepository<PermissionGroup>(true);

            var userPermissionGroups = await userPermissionGroupRepository.Query().ToListAsync(cancellationToken);
            List<UserPermissionGroupDTO> userPermissionDetails = new List<UserPermissionGroupDTO>();
            int i = 0;
            foreach (var permission in userPermissionGroups)
            {
                var user = _mapper.Map<UserDTO>((await userRepository.Query().Where(user => user.Id == permission.UserId).ToListAsync())[0]);
                var permissionGroup = _mapper.Map<PermissionGroupDTO>((await permissionGroupRepository.Query().Where(per => per.Id == permission.PermissionGroupId).ToListAsync())[0]);
                i += 1;
                userPermissionDetails.Add(new UserPermissionGroupDTO()
                {
                    Id = i,
                    UserId = permission.UserId,
                    User = user,
                    PermissionGroupId = permission.Id,
                    PermissionGroup = permissionGroup,
                    PhoneNumber = permission.PhoneNumber
                });
            }

            return userPermissionDetails;
        }

        public async Task<List<UserPermissionGroupDTO>> GetLoggedInUserPermissionGroupsAsync(int userId, CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();

            var userPermissionGroupRepository = unitOfWork.CreateRepository<UserPermissionGroup>(false);
            var userRepository = unitOfWork.CreateRepository<User>(true);
            var permissionGroupRepository = unitOfWork.CreateRepository<PermissionGroup>(true);

            var userPermissionGroups = await userPermissionGroupRepository.Query().Where(usr => usr.UserId == userId).ToListAsync(cancellationToken);
            List<UserPermissionGroupDTO> userPermissionDetails = new List<UserPermissionGroupDTO>();
            int i = 0;
            foreach (var permission in userPermissionGroups)
            {
                var user = _mapper.Map<UserDTO>((await userRepository.Query().Where(user => user.Id == permission.UserId).ToListAsync())[0]);
                var permissionGroup = _mapper.Map<PermissionGroupDTO>((await permissionGroupRepository.Query().Where(per => per.Id == permission.PermissionGroupId).ToListAsync())[0]);
                i += 1;
                userPermissionDetails.Add(new UserPermissionGroupDTO()
                {
                    Id = i,
                    UserId = permission.UserId,
                    User = user,
                    PermissionGroupId = permission.Id,
                    PermissionGroup = permissionGroup
                });
            }

            return userPermissionDetails;
        }

        public async Task<List<string>> GetUsersDepartmentListAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();
            var userRepository = unitOfWork.CreateRepository<User>(false);

            var departmentList = _mapper.Map<List<string>>(await userRepository.Query().Select(o => o.Department).Distinct().ToListAsync(cancellationToken));
            return departmentList;
        }

        public async Task<List<UserContactDetailsDTO>> GetDashboardContactDetailsAsync(CancellationToken cancellationToken)
        {
            using var unitOfWork = UnitOfWorkFactory.GetInstance();

            var userPermissionGroupRepository = unitOfWork.CreateRepository<UserPermissionGroup>(false);
            var userRepository = unitOfWork.CreateRepository<User>(true);
            var permissionGroupRepository = unitOfWork.CreateRepository<PermissionGroup>(true);

            var adminPermissionGroupId = (await permissionGroupRepository.Query().Where(per => per.Name == "Admin").ToListAsync())[0].Id;
            var userPermissionGroups = await userPermissionGroupRepository.Query().Where(up => up.PermissionGroupId != adminPermissionGroupId).ToListAsync(cancellationToken);
            List<UserContactDetailsDTO> userPermissionDetails = new List<UserContactDetailsDTO>();
            int i = 0;
            foreach (var permission in userPermissionGroups)
            {
                var user = (await userRepository.Query().Where(user => user.Id == permission.UserId).ToListAsync())[0];
                var permissionGroup = (await permissionGroupRepository.Query().Where(per => per.Id == permission.PermissionGroupId).ToListAsync())[0];
                i += 1;
                userPermissionDetails.Add(new UserContactDetailsDTO()
                {
                    Id = i,
                    UserId = permission.UserId,
                    EmailId = user.CompanyEmailId,
                    UserName = user.FullName,
                    PermissionGroupName = permissionGroup.Name,
                    PhoneNumber = permission.PhoneNumber
                });
            }

            return userPermissionDetails;
        }

    }

}