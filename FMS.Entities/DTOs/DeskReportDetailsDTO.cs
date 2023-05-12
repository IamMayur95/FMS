using System;
using FMS.Entities.Models;
using FMS.Entities.Models.Enums;

namespace FMS.Entities.DTOs
{
    public class DeskReportDetailsDTO
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
        public DeskStatusType Status { get; set; }
        public BookingDetail Bookingdetails { get; set; }
    }
}
