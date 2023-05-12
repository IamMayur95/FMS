using System;
using System.ComponentModel.DataAnnotations.Schema;
using FMS.Core.Common.Contracts.AuditTrails;
using FMS.Core.Common.Contracts.Diff;
using Utils.Data.Attributes;

namespace FMS.Entities.Models.Base
{
    public abstract class BaseAuditableModel : BaseModel, IAuditTrailEntity
    {
        [SimpleIndex]
        public AuditState AuditState { get; set; } = AuditState.Created;

        [DiffSkip]
        public DateTime CreatedDate { get; set; }

        [DiffSkip]
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey(nameof(CreatedByUser))]
        public int? CreatedBy { get; set; }

        [ForeignKey(nameof(UpdatedByUser))]
        public int? UpdatedBy { get; set; }

        public virtual User CreatedByUser { get; set; }

        public virtual User UpdatedByUser { get; set; }
    }
}
