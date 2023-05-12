using Microsoft.EntityFrameworkCore.Storage;
using FMS.Core.Common.Contracts.Repositories;
using FMS.Core.Common.Data;
using FMS.Data.Contexts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.Data.UnitOfWork
{
    internal sealed class UnitOfWork : ReadonlyUnitOfWork
    {
        private IDbContextTransaction _transaction = null;
        private bool _useTransaction = false;

        public UnitOfWork(FMSContext context) : base(context)
        {
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        protected override void Dispose(bool isDisposing)
        {
            if (!_isDisposed)
            {
                if (isDisposing)
                {
                    if (_transaction is not null)
                    {
                        _transaction.Rollback();
                        _transaction.Dispose();
                        _transaction = null;
                    }
                }

                base.Dispose(isDisposing);
                _isDisposed = true;
            }
        }

        private void StartTransaction()
        {
            if (_context.Database.CurrentTransaction == null)
            {
                _transaction = _context.Database.BeginTransaction();
                _useTransaction = true;
            }
        }

        private void CommitTransaction()
        {
            if (_transaction is not null)
            {
                _transaction.Commit();
                _transaction.Dispose();
                _transaction = null;
            }
            else if (_useTransaction)
            {
                throw new InvalidOperationException("The transaction was already committed.");
            }
        }

        public override IRepository<T> CreateRepository<T>(bool isReadonly = true)
        {
            if (isReadonly)
            {
                return new ReadOnlyRepository<T>(_context);
            }

            if (System.Transactions.Transaction.Current == null)
            {
                StartTransaction();
            }

            return new ReadWriteRepository<T, FMSContext>(_context);
        }

        public override async Task<int> SaveAsync(CancellationToken cancellationToken, bool commit = true)
        {
            if (_context.Database.CurrentTransaction == null && System.Transactions.Transaction.Current == null)
            {
                throw new InvalidOperationException("Saving data to database is only allowed using a transaction. Make sure there is a transaction created by calling CreateRepository(false).");
            }

            var result = await _context.SaveChangesAsync(cancellationToken);
            if (commit)
            {
                CommitTransaction();
            }

            return result;
        }
    }
}
