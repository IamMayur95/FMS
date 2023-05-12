using FMS.Entities.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace FMS.Entities.Models
{
    public class LocationDetail: BaseAuditableModel
    {
        [StringLength(4000)]
        [Required]
        public string Name { get; set; }

        public int Order { get; set; }
    }
}
