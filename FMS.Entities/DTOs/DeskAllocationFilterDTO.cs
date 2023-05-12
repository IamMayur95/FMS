using System;
using FMS.Entities.Models.Enums;

namespace FMS.Entities.DTOs
{
    public class DeskAllocationFilterDTO
    {
        public LocationDetailDTO? Location { get; set; }
        public FloorDetailDTO? Floor { get; set; }
        public WingDetailDTO? Wing { get; set; }
    }

}
