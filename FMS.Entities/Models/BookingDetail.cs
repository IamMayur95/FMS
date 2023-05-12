using FMS.Entities.Models.Base;
using FMS.Entities.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FMS.Entities.Models
{
    public class BookingDetail : BaseAuditableModel
    {

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }

        public virtual User User { get; set; }


        [ForeignKey(nameof(Desk))]
        public int? DeskId { get; set; }

        public virtual DeskDetail Desk { get; set; }

        public DateTime? BookingFromDate { get; set; }

        public DateTime? BookingToDate { get; set; }

        [ForeignKey(nameof(BookedByUser))]
        public int? BookedByUserId { get; set; }

        public virtual User BookedByUser { get; set; }

        [ForeignKey(nameof(CancelledByUser))]
        public int? CancelledByUserId { get; set; }

        public virtual User CancelledByUser { get; set; }

        public DateTime? CancelledDate { get; set; }

        public FMSBookingType BookingType { get; set; }

        [StringLength(4000)]
        public string Comments { get; set; }


        public int? StatusTypeId { get; set; }

        public virtual StatusType StatusType { get; set; }
    }
}
