using FMS.Entities.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class FloorDetail : BaseAuditableModel
    {
        [StringLength(4000)]
        [Required]
        public string Name { get; set; }


        [ForeignKey(nameof(BuildingDetail))]
        public int? BuildingDetailId { get; set; }

        public virtual BuildingDetail BuildingDetail { get; set; }

        public int Order { get; set; }

        public bool IsActive { get; set; }
    }
}
