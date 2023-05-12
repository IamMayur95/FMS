namespace FMS.Entities.DTOs
{
    public class WingDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? FloorDetailId { get; set; }

        public virtual FloorDetailDTO FloorDetail { get; set; }


        public int Order { get; set; }
    }
}
