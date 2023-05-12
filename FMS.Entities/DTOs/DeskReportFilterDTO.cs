using System;
using FMS.Entities.Models.Enums;

namespace FMS.Entities.DTOs
{
    public class DeskReportFilterDTO
    {
        public LocationDetailDTO? Location { get; set; }
        public FloorDetailDTO? Floor { get; set; }
        public WingDetailDTO? Wing { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public DeskStatusType Status { get; set; }
    }

}
