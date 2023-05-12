using FMS.Entities.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class WingDetail : BaseAuditableModel
    {
        [StringLength(4000)]
        [Required]
        public string Name { get; set; }


        [ForeignKey(nameof(FloorDetail))]
        public int? FloorDetailId { get; set; }

        public virtual FloorDetail FloorDetail { get; set; }

        public int Order { get; set; }
    }
}
