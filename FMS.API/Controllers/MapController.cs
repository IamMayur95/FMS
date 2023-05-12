using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.API.Controllers
{

    [Authorize]
    public class MapController : BaseArgsController
    {
        private readonly IMapConfigurationService _mapConfigurationService;

        public MapController(IRequestContextService requestContextService, IMapConfigurationService mapConfigurationService) : base(requestContextService)
        {
            _mapConfigurationService = mapConfigurationService;
        }

        [HttpPost("[action]")]
        public async Task<List<MapConfigurationWithDeskDataDTO>> GetMapConfigurationWithDeskData(string request, CancellationToken cancellationToken)
        {
            var retVal = await _mapConfigurationService.GetMapConfigurationWithDeskDataAsync(request, cancellationToken);
            return retVal;
        }

    }
}