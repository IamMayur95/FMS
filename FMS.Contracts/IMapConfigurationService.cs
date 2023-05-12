using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IMapConfigurationService : IBaseService
    {
        Task<List<MapConfigurationWithDeskDataDTO>> GetMapConfigurationWithDeskDataAsync(string request, CancellationToken cancellationToken);
    }
}
