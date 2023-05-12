using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IAccountService : IBaseService
    {
        Task<UserDTO> GetUserInfoAsync(string accessId, CancellationToken cancellationToken);

        Task<UserDTO> GetUserInfoByUserIdAsync(int userId, CancellationToken cancellationToken);
    }
}
