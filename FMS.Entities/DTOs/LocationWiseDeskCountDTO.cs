using System;

namespace FMS.Entities.DTOs
{
    public class LocationWiseDeskCountDTO
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int FreeDeskCount { get; set; }
        public int BookedDeskCount { get; set; }
        public int MaintenanceDeskCount { get; set; }
    }
}
