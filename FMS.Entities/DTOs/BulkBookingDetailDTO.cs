using FMS.Entities.Models.Enums;
using System;

namespace FMS.Entities.DTOs
{
    public class BulkBookingDetailDTO
    {
        public int DeskId { get; set; }
        public int? UserId { get; set; }
        public int? BookingId { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual DeskDetailDTO Desk { get; set; }
        public DateTime? BookingFromDate { get; set; }
        public DateTime? BookingToDate { get; set; }
        public int? BookedByUserId { get; set; }
        public virtual UserDTO BookedByUser { get; set; }
        public int? CancelledByUserId { get; set; }
        public virtual UserDTO CancelledByUser { get; set; }
        public DateTime? CancelledDate { get; set; }
        public FMSBookingType BookingType { get; set; }
        public string Comments { get; set; }
        public int? StatusTypeId { get; set; }
        public virtual StatusTypeDTO StatusType { get; set; }
    }
}
