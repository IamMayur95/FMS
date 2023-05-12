using System;
using System.Collections.Generic;

namespace FMS.Core.Common.Contracts.Paging
{
    public class PaginatedList<T> : IPaginatedList<T> where T : class
    {
        public PaginatedList(IEnumerable<T> items, int currentPage, int pageSize, long totalCount)
        {
            TotalCount = totalCount;

            TotalPages = (int)Math.Ceiling(TotalCount / (double)pageSize);
            HasNextPage = currentPage < TotalPages;
            HasPreviousPage = currentPage > 1;

            Items = new List<T>(items);
        }

        public IReadOnlyCollection<T> Items { get; }

        public bool HasNextPage { get; }

        public bool HasPreviousPage { get; }

        public long TotalCount { get; }

        public int TotalPages { get; }
    }
}
