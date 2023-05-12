using FMS.Entities.Models;
using FMS.Entities.Models.Enums;

namespace FMS.Entities.DTOs
{
    public class StatusTypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FMSBookingType Type { get; set; }
    }
}
