using System.Collections.Generic;

namespace FMS.Entities.DTOs
{
    public class MasterDataDTO
    {
        public List<LocationDetailDTO> LocationDetailDTOs { get; set; } = new List<LocationDetailDTO>();
        public List<FloorDetailDTO> FloorDetailDTOs { get; set; } = new List<FloorDetailDTO>();

        public List<WingDetailDTO> WingDetailDTOs { get; set; } = new List<WingDetailDTO>();
        public List<BuildingDetailDTO> BuildingDetailDTOs { get; set; } = new List<BuildingDetailDTO>();

        public List<StatusTypeDTO> StatusTypeDTOs { get; set; } = new List<StatusTypeDTO>();
    }
}
