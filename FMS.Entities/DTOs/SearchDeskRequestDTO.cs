namespace FMS.Entities.DTOs
{
    public class SearchDeskRequestDTO
    {
        public LocationDetailDTO? Location { get; set; }

        public FloorDetailDTO? Floor { get; set; }

        public WingDetailDTO? Wing { get; set; }

        public string FromDate { get; set; }

        public string ToDate { get; set; }

        public string SearchText { get; set; }
    }

}
