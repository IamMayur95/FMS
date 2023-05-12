using AutoMapper;
using FMS.Contracts;
using FMS.Core.Services;
using FMS.Data.Contexts;
using FMS.Data.UnitOfWork;
using FMS.Entities.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS.Services.Services
{

    public class MasterDataService : BaseAuditableService, IMasterDataService
    {
        private readonly IMapper _mapper;
        private readonly FMSContext _context;

        public MasterDataService(IUnitOfWorkFactory unitOfWorkFactory, FMSContext context, IMapper mapper) : base(unitOfWorkFactory)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<MasterDataDTO> GetMasterDataAsync()
        {
            var buildingDetailDTOs = _mapper.Map<List<BuildingDetailDTO>>(_context.BuildingDetails.OrderBy(a=>a.Order).ToList());
            var floorDetailDTOs = _mapper.Map<List<FloorDetailDTO>>(_context.FloorDetails.Where(a => a.IsActive).OrderBy(a => a.Order).ToList());
            var locationDetailDTOs = _mapper.Map<List<LocationDetailDTO>>(_context.LocationDetails.OrderBy(a => a.Order).ToList());
            var statusTypeDTOs = _mapper.Map<List<StatusTypeDTO>>(_context.StatusTypes.ToList());
            var wingDetailsDTOs = _mapper.Map<List<WingDetailDTO>>(_context.WingDetails.OrderBy(a => a.Order).ToList());


            var masterDataDTO = new MasterDataDTO
            {
                BuildingDetailDTOs = buildingDetailDTOs,
                FloorDetailDTOs = floorDetailDTOs,
                LocationDetailDTOs = locationDetailDTOs,
                StatusTypeDTOs = statusTypeDTOs,
                WingDetailDTOs = wingDetailsDTOs,
            };
            return await Task.FromResult(masterDataDTO);
        }
    }

}
