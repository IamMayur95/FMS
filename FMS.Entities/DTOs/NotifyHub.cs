using Microsoft.AspNetCore.SignalR;
using FMS.Contracts;

namespace FMS.Entities.DTOs
{
    public class NotifyHub : Hub<ITypedHubClient>
    {
    }
}
