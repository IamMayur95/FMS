using AutoMapper;
using FMS.Contracts;
using FMS.Core.Common.Utils;
using FMS.Core.Services;
using FMS.Data.Contexts;
using FMS.Data.UnitOfWork;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Services.Services
{
    public class RequestContextService : BaseAuditableService, IRequestContextService
    {
        private readonly IMapper _mapper;
        private readonly FMSContext _context;

        public RequestContextService(
            FMSContext context,
            IMapper mapper,
            IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<BaseArgs> GetActiveArgsAsync(string accessId, CancellationToken cancellationToken)
        {
            return new BaseArgs();
        }

        public async Task<bool> IsAdminUserAsync(string accessId, CancellationToken cancellationToken)
        {
            var isSuperUser = false;
            //if (!string.IsNullOrEmpty(accessId))
            //{
                
            //    var userPermissionGroups = await GetUserPermissionGroupsAsync(userId, cancellationToken);

            //    if (userPermissionGroups?.Count > 0)
            //    {
            //        isSuperUser = userPermissionGroups
            //           .Any(item => item.Name.ToLower().Equals(ApiConstants.AdminUserPermissionGroupName.ToLower()));
            //    }
            //}

            return isSuperUser;
        }


        public Task<bool> SetActiveArgsAsync(BaseArgs args)
        {
            throw new NotImplementedException();
        }
    }
}
