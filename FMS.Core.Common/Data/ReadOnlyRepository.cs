using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using FMS.Core.Common.Contracts.AuditTrails;
using FMS.Core.Common.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;
using Utils.Data.Extensions;

namespace FMS.Core.Common.Data
{
    public class ReadOnlyRepository<T> : IRepository<T> where T : class, IAuditTrailEntity
    {
        #region Fields

        private readonly DbContext _context;

        #endregion Fields

        public ReadOnlyRepository(DbContext context)
        {
            _context = context;
        }

        #region IRepository Members

        public bool IsReadOnly => true;

        public IQueryable<T> Query()
        {
            return _context.Set<T>()
                .AsNoTracking() // Optimized read-only access
                .GetCurrentVersions();
        }

        public IQueryable<T> QueryById(int id)
        {
            return Query().Where(m => m.Id == id);
        }

        public IQueryable<T> QueryByIds(IEnumerable<int> ids)
        {
            return Query().Where(m => ids.Contains(m.Id));
        }

        public async Task<T> GetById(int id, CancellationToken cancellationToken)
        {
            return await Query()
                .SingleAsync(m => m.Id == id, cancellationToken);
        }

        public async Task<T> TryGetById(int id, CancellationToken cancellationToken)
        {
            return await Query()
                .SingleOrDefaultAsync(m => m.Id == id, cancellationToken);
        }

        public IQueryable<T> GetByIds(IEnumerable<int> ids)
        {
            return Query().Where(m => ids.Contains(m.Id));
        }

        public IQueryable<T> QueryIncludeEntities<TInclude>()
        {
            var query = Query();

            return _context.QueryIncludeEntities<T, TInclude>(query);
        }

        public IQueryable<T> QueryIncludeEntities<TInclude>(int id)
        {
            var query = QueryById(id);

            return _context.QueryIncludeEntities<T, TInclude>(query);
        }

        public T Add(T entity, int userId)
             => throw new InvalidOperationException("A read-only repository cannot modify entities.");

        public void Add(IEnumerable<T> entities, int userId)
             => throw new InvalidOperationException("A read-only repository cannot modify entities.");

        public async Task Update(T entity, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));

        public async Task Update(IEnumerable<T> entites, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entites."));

        public async Task<T> AddOrUpdate(T entity, int userId, CancellationToken cancellationToken)
        {
            await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));
            return default;
        }

        public async Task<IEnumerable<T>> AddOrUpdate(IEnumerable<T> entities, int userId, CancellationToken cancellationToken)
        {
            await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));
            return default;
        }

        public async Task<IEnumerable<T>> AddOrUpdateOrRemove(IEnumerable<T> entities, IEnumerable<int> existingIds, int userId, CancellationToken cancellationToken)
        {
            await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));
            return default;
        }

        public async Task Remove(T entity, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));

        public async Task Remove(int id, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));

        public async Task Remove(IEnumerable<int> entityIds, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));

        public async Task Remove(IEnumerable<int?> entityIds, int userId, CancellationToken cancellationToken)
            => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));

        public async Task Remove(IEnumerable<T> entities, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entites."));

        public async Task Remove(Expression<Func<T, bool>> entitySelection, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));

        public int MarkForHardDeletion(IEnumerable<T> entities, int userId)
            => throw new InvalidOperationException("A read-only repository cannot modify entities.");

        public async Task UpdateCollection<TChange>(IEnumerable<T> entities, IEnumerable<TChange> changes, Func<TChange, int?> idSelector, Action<T, TChange> applyChanges, Func<T> createNewEntity, int userId, CancellationToken cancellationToken)
             => await Task.FromException(new InvalidOperationException("A read-only repository cannot modify entities."));

        #endregion
    }
}
