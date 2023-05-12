using System.Threading.Tasks;
using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;

namespace FMS.Contracts
{
    public interface ITypedHubClient : IBaseService
    {
        Task BroadcastMessage(PublishEventData message);
    }
}
