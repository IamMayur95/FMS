using FMS.Entities.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;
using FMS.Entities.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace FMS.Entities.Models
{
    public class UserPermissionGroup : BaseAuditableModel
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        [ForeignKey(nameof(PermissionGroup))]
        public int PermissionGroupId { get; set; }
        public virtual User User { get; set; }
        public virtual PermissionGroup PermissionGroup { get; set; }
        public string PhoneNumber { get; set; }
    }
}
