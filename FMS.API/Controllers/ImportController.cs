using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Core.Common.Contracts.Configuration;
using FMS.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.API.Controllers
{
    public class ImportController : BaseController
    {
        private readonly ILogger<ImportController> _logger;
        private readonly ApplicationSettings _applicationSettings;
        private readonly IImportService _importService;

        public ImportController(ILogger<ImportController> logger,
            IImportService importService,
            ApplicationSettings applicationSettings)
        {
            _logger = logger;
            _applicationSettings = applicationSettings;
            _importService = importService;
        }

        [HttpPost("[action]")]
        public async Task<bool> ImportActiveUsers(List<ImportUserDTO> userDTOs)
        {
            if (userDTOs?.Count > 0)
            {
                var result = await _importService.ImportUsersAsync(userDTOs, true, CancellationToken.None);
                return result;
            }

            return false;
        }

        [HttpPost("[action]")]
        public async Task<bool> ImportInactiveUsers(List<ImportUserDTO> userDTOs)
        {
            if (userDTOs?.Count > 0)
            {
                var result = await _importService.ImportUsersAsync(userDTOs, false, CancellationToken.None);
                return result;
            }

            return false;
        }


    }
}
