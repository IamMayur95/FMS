using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IAnalyticsService : IBaseService
    {
        Task<AnalyticsDTO> GetBookingCapacityAnalyticsDataAsync(int floorId, CancellationToken cancellationToken);

        Task<AnalyticsDTO> GetFrequentBookingAnalyticsDataAsync(int wingId, CancellationToken cancellationToken);

        Task<AnalyticsDTO> GetLocationWiseBookingAnalyticsDataAsync(CancellationToken cancellationToken);
    }
}
