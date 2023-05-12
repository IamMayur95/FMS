using System.Collections.Generic;

namespace FMS.Core.Common.Contracts.Paging
{
    public interface IPaginatedList<T>
    {
        IReadOnlyCollection<T> Items { get; }

        bool HasNextPage { get; }

        bool HasPreviousPage { get; }

        int TotalPages { get; }

        long TotalCount { get; }
    }
}
