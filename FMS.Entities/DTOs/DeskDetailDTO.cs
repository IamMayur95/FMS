using System;

namespace FMS.Entities.DTOs
{
    public class DeskDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Section { get; set; }


        public string SeatNumber { get; set; }


        public int? LocationDetailId { get; set; }

        public virtual LocationDetailDTO LocationDetail { get; set; }

        public int? BuildingDetailId { get; set; }

        public virtual BuildingDetailDTO BuildingDetail { get; set; }
        public int? WingDetailId { get; set; }

        public virtual WingDetailDTO WingDetail { get; set; }
        public int? FloorDetailId { get; set; }

        public virtual FloorDetailDTO FloorDetail { get; set; }

        public int? StatusTypeId { get; set; }

        public virtual StatusTypeDTO StatusType { get; set; }
        public DateTime? BookingFromDate { get; set; }
        public DateTime? BookingToDate { get; set; }

        public bool IsBlockedSeat { get; set; }

        public string Comments { get; set; }
    }

}
