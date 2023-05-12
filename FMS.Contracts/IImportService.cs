using FMS.Core.Common.Contracts;
using FMS.Entities.DTOs;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Contracts
{
    public interface IImportService : IBaseService
    {
        Task<bool> ImportUsersAsync(List<ImportUserDTO> projectDTOs, bool isActive, CancellationToken cancellationToken);
    }
}
