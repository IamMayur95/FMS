using FMS.Entities.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class DeskDetail : BaseAuditableModel
    {
        [StringLength(4000)]
        public string Section { get; set; }


        [StringLength(500)]
        [Required]
        public string SeatNumber { get; set; }


        [ForeignKey(nameof(LocationDetail))]
        public int? LocationDetailId { get; set; }

        public virtual LocationDetail LocationDetail { get; set; }


        [ForeignKey(nameof(BuildingDetail))]
        public int? BuildingDetailId { get; set; }

        public virtual BuildingDetail BuildingDetail { get; set; }

        [ForeignKey(nameof(WingDetail))]
        public int? WingDetailId { get; set; }

        public virtual WingDetail WingDetail { get; set; }

        [ForeignKey(nameof(FloorDetail))]
        public int? FloorDetailId { get; set; }

        public virtual FloorDetail FloorDetail { get; set; }

        [ForeignKey(nameof(StatusType))]
        public int? StatusTypeId { get; set; }

        public virtual StatusType StatusType { get; set; }

        public bool IsBlockedSeat { get; set; }

        public string Comments { get; set; }
    }
}
