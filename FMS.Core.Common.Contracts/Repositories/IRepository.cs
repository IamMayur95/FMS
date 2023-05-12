using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

using FMS.Core.Common.Contracts.AuditTrails;

namespace FMS.Core.Common.Contracts.Repositories
{
    public interface IRepository<T> where T : class, IAuditTrailEntity
    {
        bool IsReadOnly { get; }

        IQueryable<T> Query();

        IQueryable<T> QueryById(int id);

        IQueryable<T> QueryByIds(IEnumerable<int> ids);

        IQueryable<T> QueryIncludeEntities<TInclude>();

        IQueryable<T> QueryIncludeEntities<TInclude>(int id);

        Task<T> GetById(int id, CancellationToken cancellationToken);
        Task<T> TryGetById(int id, CancellationToken cancellationToken);

        IQueryable<T> GetByIds(IEnumerable<int> ids);

        T Add(T entity, int userId);

        void Add(IEnumerable<T> entities, int userId);

        Task Update(T entity, int userId, CancellationToken cancellationToken);

        Task Update(IEnumerable<T> entities, int userId, CancellationToken cancellationToken);

        Task<T> AddOrUpdate(T entity, int userId, CancellationToken cancellationToken);

        Task<IEnumerable<T>> AddOrUpdate(IEnumerable<T> entities, int userId, CancellationToken cancellationToken);

        Task<IEnumerable<T>> AddOrUpdateOrRemove(IEnumerable<T> allEntities, IEnumerable<int> allExistingIds, int userId, CancellationToken cancellationToken);

        Task Remove(int id, int userId, CancellationToken cancellationToken);

        Task Remove(T entity, int userId, CancellationToken cancellationToken);

        Task Remove(IEnumerable<int> entityIds, int userId, CancellationToken cancellationToken);

        Task Remove(IEnumerable<int?> entityIds, int userId, CancellationToken cancellationToken);

        Task Remove(IEnumerable<T> entities, int userId, CancellationToken cancellationToken);

        Task Remove(Expression<Func<T, bool>> entitySelection, int userId, CancellationToken cancellationToken);

        int MarkForHardDeletion(IEnumerable<T> entities, int userId);

        Task UpdateCollection<TChange>(
            IEnumerable<T> entities,
            IEnumerable<TChange> changes,
            Func<TChange, int?> idSelector,
            Action<T, TChange> applyChanges,
            Func<T> createNewEntity,
            int userId,
            CancellationToken cancellationToken);
    }
}
