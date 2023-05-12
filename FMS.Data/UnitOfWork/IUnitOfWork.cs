using FMS.Core.Common.Contracts.AuditTrails;
using FMS.Core.Common.Contracts.Repositories;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void DisableChangeDetection();
        void EnableChangeDetection();
        IRepository<T> CreateRepository<T>(bool isReadonly = true) where T : class, IAuditTrailEntity;
        Task<int> SaveAsync(CancellationToken cancellationToken, bool commit = true);
    }
}
