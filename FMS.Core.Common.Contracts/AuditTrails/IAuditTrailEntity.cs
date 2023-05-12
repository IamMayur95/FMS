using System;

namespace FMS.Core.Common.Contracts.AuditTrails
{
    public interface IAuditTrailEntity : IHasId
    {
        AuditState AuditState { get; set; }

        DateTime CreatedDate { get; set; }

        DateTime? UpdatedDate { get; set; }

        //int? CreatedBy { get; set; }

        //int? UpdatedBy { get; set; }
    }
}
