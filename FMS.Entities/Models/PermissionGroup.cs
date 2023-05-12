using FMS.Entities.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace FMS.Entities.Models
{
    public class PermissionGroup : BaseAuditableModel
    {
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
