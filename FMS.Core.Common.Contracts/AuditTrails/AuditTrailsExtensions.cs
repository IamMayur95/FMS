using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FMS.Core.Common.Contracts.AuditTrails
{
    public static class AuditTrailsExtensions
    {
        #region Filter Expression Definitions

        private static Expression<Func<T, bool>> FilterCurrentVersions<T>()
              where T : class, IAuditTrailEntity
        {
            return m => m.AuditState != AuditState.Deleted;
        }

        #endregion

        public static IQueryable<T> GetCurrentVersions<T>(this IQueryable<T> query)
            where T : class, IAuditTrailEntity
        {
            return query.Where(FilterCurrentVersions<T>());
        }
    }
}
