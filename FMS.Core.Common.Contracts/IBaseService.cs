using FMS.Core.Common.Contracts.Enums;

namespace FMS.Core.Common.Contracts
{
    public interface IBaseService
    {
    }

    public interface IAuditableService : IBaseService
    {
        InputAuditType AuditType { get; set; }
    }
}
