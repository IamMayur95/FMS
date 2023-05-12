using System.Collections.Generic;
using System.Linq;

namespace FMS.Core.Common.Paging
{
    public static class PagingExtensions
    {
        public static IQueryable<T> Paging<T>(this IQueryable<T> source, int currentPage, int pageSize)
            => source
                .Skip(currentPage * pageSize)
                .Take(pageSize);

        public static IList<T> Paging<T>(this IList<T> source, int currentPage, int pageSize)
            => source
                .Skip(currentPage * pageSize)
                .Take(pageSize)
                .ToList();

        public static IEnumerable<T> Paging<T>(this IEnumerable<T> source, int currentPage, int pageSize)
            => source
                .Skip(currentPage * pageSize)
                .Take(pageSize);
    }
}