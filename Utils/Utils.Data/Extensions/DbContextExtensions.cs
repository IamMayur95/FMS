using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Utils.Data.Extensions
{
    public static class DbContextExtensions
    {
        public static IQueryable<TEntity> QueryIncludeEntities<TEntity, TInclude>(this DbContext dbContext, IQueryable<TEntity> baseQuery)
            where TEntity : class
        {
            return dbContext.Model
                .FindEntityType(typeof(TEntity))
                .GetNavigations()
                .Aggregate(baseQuery, (current, property) =>
                {
                    if (property.ClrType == typeof(TInclude))
                    {
                        return current.Include(property.Name);
                    }

                    return current;
                });
        }

        public static TEntity Create<TEntity>(this DbSet<TEntity> @this, TEntity newEntity = null)
           where TEntity : class, new()
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            newEntity ??= new TEntity();

            @this.Add(newEntity);
            return newEntity;
        }

    }
}
