using FMS.Core.Common.Contracts.AuditTrails;
using FMS.Core.Common.Contracts.Repositories;
using FMS.Core.Common.Data;
using FMS.Data.Contexts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Data.UnitOfWork
{
    internal class ReadonlyUnitOfWork : IUnitOfWork
    {
        protected FMSContext _context;
        protected bool _isDisposed;

        public ReadonlyUnitOfWork(FMSContext context)
        {
            _context = context;
        }

        protected virtual void Dispose(bool isDisposing)
        { }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void DisableChangeDetection()
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public void EnableChangeDetection()
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = true;
        }

        public virtual IRepository<T> CreateRepository<T>(bool isReadonly = true) where T : class, IAuditTrailEntity
        {
            return isReadonly
                ? new ReadOnlyRepository<T>(_context)
                : throw new ArgumentException("Cannot create Read/Write Repository from Readonly Unit of Work");
        }

        public virtual async Task<int> SaveAsync(CancellationToken cancellationToken, bool commit = true)
        {
            await Task.FromException(new InvalidOperationException("Forbidden action in Readonly Unit of Work"));
            return 0;
        }
    }
}
