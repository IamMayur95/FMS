using System;

namespace Utils.Common.Interfaces
{
    public interface IHasId<TId> 
        where TId : IEquatable<TId>, IComparable<TId>
    {
        TId Id { get; }
    }

    public interface IHasId : IHasId<int>
    {
    }
}
