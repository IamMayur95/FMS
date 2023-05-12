using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FMS.API.Controllers
{
    public class MasterDataController : BaseController
    {

        private readonly ILogger<MasterDataController> _logger;
        private readonly IMasterDataService _masterService;

        public MasterDataController(ILogger<MasterDataController> logger,
            IMasterDataService masterService)
        {
            _logger = logger;
            _masterService = masterService;
        }


        [HttpGet("[action]")]
        public async Task<MasterDataDTO> GetMasterData()
        {
            var masterDataDTO = await _masterService.GetMasterDataAsync();

            return masterDataDTO;
        }

    }
}
