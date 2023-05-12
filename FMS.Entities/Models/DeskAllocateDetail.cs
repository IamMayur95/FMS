using FMS.Entities.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class DeskAllocateDetail : BaseAuditableModel
    {
        public int DeskId { get; set; }
        public bool IsBlock { get; set; } = false;
        public string Department { get; set; }
        public string OtherDepartmentOrTeam { get; set; }

        [ForeignKey(nameof(AllocatedByUser))]
        public int? AllocatedByUserId { get; set; }
        public virtual User AllocatedByUser { get; set; }
    }
}
