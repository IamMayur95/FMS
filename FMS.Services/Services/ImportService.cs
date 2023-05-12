using AutoMapper;
using FMS.Contracts;
using FMS.Core.Common.Contracts.Repositories;
using FMS.Core.Services;
using FMS.Data.Contexts;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using FMS.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Services.Services
{

    public class ImportService : BaseAuditableService, IImportService
    {
        private readonly IMapper _mapper;
        private readonly FMSContext _context;

        public ImportService(IUnitOfWorkFactory unitOfWorkFactory, FMSContext context, IMapper mapper) : base(unitOfWorkFactory)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<bool> ImportUsersAsync(List<ImportUserDTO> usersDTOs, bool isActive, CancellationToken cancellationToken)
        {
            if (usersDTOs?.Count > 0)
            {
                using var unitOfWork = UnitOfWorkFactory.GetInstance();
                var userRepository = unitOfWork.CreateRepository<User>(false);

                var existingUsers = await userRepository.Query().ToListAsync(cancellationToken);

                foreach (var user in usersDTOs)
                {
                    try
                    {
                        var exisitingUser = existingUsers.FirstOrDefault(x => user.Employee_Id != null && x.EmployeeId == user.Employee_Id.TrimEnd() && x.CompanyEmailId == user.Company_Email_Id.TrimEnd());
                        await SaveUserAsync(userRepository, user, exisitingUser, isActive, cancellationToken);
                        await unitOfWork.SaveAsync(cancellationToken, false);
                    }
                    catch (Exception ex) { }
                }

                await unitOfWork.SaveAsync(cancellationToken);
            }

            return true;
        }

        private async Task SaveUserAsync(IRepository<User> userRepo, ImportUserDTO importUserDTO, User userDTO, bool isActive, CancellationToken cancellationToken)
        {
            if (userDTO == null)
            {
                var user = new User
                {
                    Id = default,
                    EmployeeId = importUserDTO.Employee_Id,
                    FullName = importUserDTO.Full_Name,
                    CompanyEmailId = importUserDTO.Company_Email_Id,
                    Department = importUserDTO.Department,
                    Designation = importUserDTO.Designation,
                    IsActive = isActive,
                };
                _context.Users.Add(user);
            }
            else
            {
                userDTO.EmployeeId = importUserDTO.Employee_Id;
                userDTO.FullName = importUserDTO.Full_Name;
                userDTO.CompanyEmailId = importUserDTO.Company_Email_Id;
                userDTO.Department = importUserDTO.Department;
                userDTO.Designation = importUserDTO.Designation;
                userDTO.IsActive = isActive;
                _context.Users.Update(userDTO);
            }
            await _context.SaveChangesAsync();
        }

    }

}
