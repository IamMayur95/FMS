using System;

namespace FMS.Entities.DTOs
{
    public class EventData
    {
        public int? UserId { get; set; }
        public DateTime? EventDateTime { get; set; }
        public string Information { get; set; }
    }
}
