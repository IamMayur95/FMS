using FMS.Core.Common.Contracts;
using FMS.Core.Common.Contracts.Enums;
using FMS.Data.UnitOfWork;
using System.Threading.Tasks;

namespace FMS.Core.Services
{
    public abstract class BaseAuditableService : IAuditableService
    {
        protected readonly IUnitOfWorkFactory UnitOfWorkFactory;

        protected BaseAuditableService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            UnitOfWorkFactory = unitOfWorkFactory;
        }

        public InputAuditType AuditType { get; set; } = InputAuditType.User;

        protected async Task<bool> IsUserRootAdminAsync(string userName, IUnitOfWork unitOfWork = null)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return false;
            }

            var uow = unitOfWork ?? UnitOfWorkFactory.GetInstance();
            try
            {
                return true;
            }
            finally
            {
                if (unitOfWork == null)
                {
                    uow.Dispose();
                }
            }
        }
    }
}

