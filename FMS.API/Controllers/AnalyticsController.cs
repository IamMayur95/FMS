using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.API.Controllers
{

    [Authorize]
    public class AnalyticsController : BaseArgsController
    {
        private readonly ILogger<AnalyticsController> _logger;
        private readonly IAnalyticsService _analyticsService;

        public AnalyticsController(IRequestContextService requestContextService, ILogger<AnalyticsController> logger, IAnalyticsService analyticsService) : base(requestContextService)
        {
            _logger = logger;
            _analyticsService = analyticsService;
        }

        [HttpPost("[action]")]
        public async Task<AnalyticsDTO> GetBookingCapacityAnalyticsData(int floorId, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var data = await _analyticsService.GetBookingCapacityAnalyticsDataAsync(floorId,cancellationToken);
            return data;
        }

        [HttpPost("[action]")]
        public async Task<AnalyticsDTO> GetFrequentBookingCapacityAnalyticsData(int wingId, CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var data = await _analyticsService.GetFrequentBookingAnalyticsDataAsync(wingId, cancellationToken);
            return data;
        }

        [HttpPost("[action]")]
        public async Task<AnalyticsDTO> GetLocationWiseBookingAnalyticsData(CancellationToken cancellationToken)
        {
            var args = GetArgsAsync();

            if (string.IsNullOrEmpty(args.EmployeeId))
                return null;

            var data = await _analyticsService.GetLocationWiseBookingAnalyticsDataAsync(cancellationToken);
            return data;
        }
    }
}