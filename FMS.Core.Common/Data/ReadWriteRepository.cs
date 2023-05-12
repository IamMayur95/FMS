using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
    public class ReadWriteRepository<T, TContext> : IRepository<T>
        where T : class, IAuditTrailEntity
        where TContext : DbContext
    {
        #region Fields

        private readonly TContext _context;

        private readonly DateTime _maxDate = SqlDateTime.MaxValue.Value;

        #endregion Fields

        #region Constructor

        public ReadWriteRepository(TContext context)
        {
            _context = context;
        }

        #endregion Constructor

        #region Utils

        private T Add(T entity, DateTime timestamp, int userId)
        {
            if (entity == null)
            {
                return null;
            }

            entity.AuditState = AuditState.Created;
          //  entity.CreatedBy = userId;
            entity.CreatedDate = timestamp;
            _context.Set<T>().Add(entity);

            return entity;
        }

        private async Task Update(T entity, DateTime timestamp, int userId, CancellationToken cancellationToken)
        {
            if (entity == null)
            {
                return;
            }

            var state = _context.Entry(entity).State;
            switch (state)
            {
                case EntityState.Modified:
                case EntityState.Unchanged:
                    // We should be here 100% of the time... keep going
                    break;

                case EntityState.Detached:
                    _context.Attach(entity);
                    break;

                // TODO: code below should be uncommented, tested and released in production: would reveal potential bad bugs breaking audit trail
                //case EntityState.Added:
                //case EntityState.Deleted:
                //    throw new ArgumentException($"Entity of type {typeof(T).Name} is in state '{state.ToString()}'. {nameof(Update)} cannot be called.");

                default:
                    return;
            }

            entity.AuditState = AuditState.Updated;
            entity.UpdatedDate = timestamp;
           // entity.UpdatedBy = userId;

            _context.Entry(entity).State = EntityState.Modified;
        }

        private async Task Remove(T entity, DateTime timestamp, int userId, CancellationToken cancellationToken)
        {
            if (entity == null)
            {
                return;
            }

            entity.AuditState = AuditState.Deleted;
            entity.UpdatedDate = timestamp;
            //entity.UpdatedBy = userId;

            _context.Entry(entity).State = EntityState.Modified;
        }

        #endregion Utils

        #region IRepository Members

        public bool IsReadOnly => false;

        public IQueryable<T> Query()
        {
            return _context.Set<T>()
                .GetCurrentVersions();
        }

        public IQueryable<T> QueryById(int id)
        {
            return Query().Where(m => m.Id == id);
        }

        public IQueryable<T> QueryByIds(IEnumerable<int> ids)
        {
            ids ??= new int[0];
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

        public T Add(T entity, int userId)
            => Add(entity, DateTime.UtcNow, userId);

        public void Add(IEnumerable<T> entities, int userId)
        {
            var now = DateTime.UtcNow;
            foreach (var entity in entities)
            {
                Add(entity, now, userId);
            }
        }

        public async Task Update(T entity, int userId, CancellationToken cancellationToken)
        {
            await Update(entity, DateTime.UtcNow, userId, cancellationToken);
        }

        public async Task Update(IEnumerable<T> entities, int userId, CancellationToken cancellationToken)
        {
            var now = DateTime.UtcNow;
            foreach (var entity in entities)
            {
                await Update(entity, now, userId, cancellationToken);
            }
        }

        public async Task<T> AddOrUpdate(T entity, int userId, CancellationToken cancellationToken)
        {
            if (entity == null)
                return null;

            if (entity.Id == default)
            {
                entity = Add(entity, userId);
            }
            else
            {
                _context.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;

                await Update(entity, userId, cancellationToken);
            }

            return entity;
        }

        public async Task<IEnumerable<T>> AddOrUpdate(IEnumerable<T> entities, int userId, CancellationToken cancellationToken)
        {
            if (entities == null)
                return Enumerable.Empty<T>();

            foreach (var entity in entities)
            {
                await AddOrUpdate(entity, userId, cancellationToken);
            }

            return entities;
        }

        public async Task<IEnumerable<T>> AddOrUpdateOrRemove(IEnumerable<T> allEntities, IEnumerable<int> allExistingIds, int userId, CancellationToken cancellationToken)
        {
            var toBeDeleted = allExistingIds
                .Except(allEntities?.Select(e => e.Id) ?? Enumerable.Empty<int>())
                .ToList();

            await Remove(toBeDeleted, userId, cancellationToken);

            var toBeAddedOrUpdated = allEntities
                .Where(e => !toBeDeleted.Contains(e.Id))
                .ToList();

            return await AddOrUpdate(toBeAddedOrUpdated, userId, cancellationToken);
        }

        public async Task Remove(T entity, int userId, CancellationToken cancellationToken)
        {
            await Remove(entity, DateTime.UtcNow, userId, cancellationToken);
        }

        public async Task Remove(int id, int userId, CancellationToken cancellationToken)
        {
            var entity = await GetById(id, cancellationToken);
            await Remove(entity, DateTime.UtcNow, userId, cancellationToken);
        }

        public async Task Remove(IEnumerable<T> entities, int userId, CancellationToken cancellationToken)
        {
            if (entities == null)
                return;

            var now = DateTime.UtcNow;
            foreach (var entity in entities)
            {
                await Remove(entity, now, userId, cancellationToken);
            }
        }

        public async Task Remove(IEnumerable<int> entityIds, int userId, CancellationToken cancellationToken)
        {
            var entities = await QueryByIds(entityIds.ToArray()).ToListAsync();
            await Remove(entities, userId, cancellationToken);
        }

        public async Task Remove(IEnumerable<int?> entityIds, int userId, CancellationToken cancellationToken)
        {
            await Remove(entityIds.Where(i => i is not null).Select(i => i.Value), userId, cancellationToken);
        }

        public async Task Remove(Expression<Func<T, bool>> entitySelection, int userId, CancellationToken cancellationToken)
        {
            var entities = await Query()
                .Where(entitySelection)
                .ToListAsync(cancellationToken);

            await Remove(entities, userId, cancellationToken);
        }

        public int MarkForHardDeletion(IEnumerable<T> entities, int userId)
        {
            var n = 0;
            if (entities == null)
                return n;

            var dbSet = _context.Set<T>();
            foreach (var entity in entities.Where(e => e is not null && e.Id != default))
            {
                dbSet.Attach(entity).State = EntityState.Deleted;
                n++;
            }

            return n;
        }

        public async Task UpdateCollection<TChange>(
            IEnumerable<T> entities,
            IEnumerable<TChange> changes,
            Func<TChange, int?> idSelector,
            Action<T, TChange> applyChanges,
            Func<T> createNewEntity, int userId,
            CancellationToken cancellationToken)
        {
            var changesByEntityId = changes
                .Select(m => (Id: idSelector(m), Entity: m))
                .ToList();

            var updatesByEntityId = changesByEntityId
                .Where(m => m.Id is not null && m.Id != 0)
                .ToDictionary(m => m.Id.Value, m => m.Entity);

            var insertionsByEntityId = changesByEntityId
                .Where(m => m.Id == null || m.Id == 0)
                .Select(m => m.Entity)
                .ToList();

            foreach (var entity in entities)
            {
                if (updatesByEntityId.TryGetValue(entity.Id, out var change))
                {
                    applyChanges(entity, change);
                    await Update(entity, userId, cancellationToken);
                }
                else
                {
                    await Remove(entity.Id, userId, cancellationToken);
                }
            }

            foreach (var change in insertionsByEntityId)
            {
                var entity = createNewEntity();
                applyChanges(entity, change);
                Add(entity, userId);
            }
        }

        #endregion 
    }
}
