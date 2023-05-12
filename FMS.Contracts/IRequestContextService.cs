using FMS.Core.Common.Contracts;
using FMS.Core.Common.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IRequestContextService : IBaseService
    {
        Task<BaseArgs> GetActiveArgsAsync(string accessId, CancellationToken cancellationToken);
        Task<bool> SetActiveArgsAsync(BaseArgs args);
        Task<bool> IsAdminUserAsync(string accessId, CancellationToken cancellationToken);
    }
}
