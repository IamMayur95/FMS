
namespace FMS.Entities.DTOs
{
    public class FloorDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? BuildingDetailId { get; set; }

        public virtual BuildingDetailDTO BuildingDetail { get; set; }

        public int Order { get; set; }

        public bool IsActive { get; set; }
    }
}
