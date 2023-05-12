using FMS.Entities.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class BuildingDetail : BaseAuditableModel
    {
        [StringLength(4000)]
        [Required]
        public string Name { get; set; }


        [ForeignKey(nameof(LocationDetail))]
        public int? LocationDetailId { get; set; }

        public virtual LocationDetail LocationDetail { get; set; }

        public int Order { get; set; }
    }
}
