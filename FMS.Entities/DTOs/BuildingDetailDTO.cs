namespace FMS.Entities.DTOs
{
    public class BuildingDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Order { get; set; }
        public int? LocationDetailId { get; set; }

        public virtual LocationDetailDTO LocationDetail { get; set; }
    }
}
