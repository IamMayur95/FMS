using System.Collections.Generic;

namespace Utils.Common.Interfaces
{
    public interface IHasRecursiveStructure : IHasId
    {
        int? ParentId { get; }
    }

    public interface IHasRecursiveStructure<T> : IHasRecursiveStructure
        where T : IHasRecursiveStructure<T>
    {
        ICollection<T> Children { get; set; }
    }
}
