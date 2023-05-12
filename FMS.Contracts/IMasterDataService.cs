using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IMasterDataService : IBaseService
    {
        Task<MasterDataDTO> GetMasterDataAsync();

    }
}
