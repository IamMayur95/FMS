using System;
using System.Collections.Generic;
using System.Linq;
using FMS.Core.Common.Contracts.AuditTrails;
using FMS.Core.Common.Extensions;

namespace FMS.Core.Common.Extensions
{
    public static class EnumerableExtensions
    {
        private class LambdaEqualityComparer<T> : IEqualityComparer<T>
        {
            private readonly Func<T, T, bool> _predicate;

            public LambdaEqualityComparer(Func<T, T, bool> predicate)
            {
                _predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));
            }

            public bool Equals(T x, T y)
            {
                return _predicate(x, y);
            }

            public int GetHashCode(T obj)
            {
                /*
                 If you just return 0 for the hash the Equals comparer will kick in. 
                 The underlying evaluation checks the hash and then short circuits the evaluation if it is false.
                 Otherwise, it checks the Equals. If you force the hash to be true (by assuming 0 for both objects), 
                 you will always fall through to the Equals check which is what we are always going for.
                */
                return 0;
            }
        }

        public static IEnumerable<(TLeft LeftValue, TRight RightValue)> Join<TLeft, TRight>(this IEnumerable<TLeft> @this, IEnumerable<TRight> inner)
            where TLeft : IHasId
            where TRight : IHasId
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            if (inner == null)
            {
                return Enumerable.Empty<(TLeft LeftValue, TRight RightValue)>();
            }

            return @this.Join(inner, o => o.Id, i => i.Id, (o, i) => (LeftValue: o, RightValue: i));
        }

        public static IEnumerable<(T Value, int Index)> Indexify<T>(this IEnumerable<T> @this)
            => @this.Select((v, i) => (Value: v, Index: i));

        public static IEnumerable<T> Distinct<T>(this IEnumerable<T> @this, Func<T, T, bool> isEqualGetter)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return @this.Distinct(new LambdaEqualityComparer<T>(isEqualGetter));
        }

        public static IEnumerable<T> Except<T>(this IEnumerable<T> @this, IEnumerable<T> listB, Func<T, T, bool> lambda)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            return @this.Except(listB, new LambdaEqualityComparer<T>(lambda));
        }

        public static IEnumerable<T> Flatten<T>(this T root, Func<T, IEnumerable<T>> childrenAccessor)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            if (childrenAccessor == null)
            {
                throw new ArgumentNullException(nameof(childrenAccessor));
            }

            return (childrenAccessor(root) ?? Enumerable.Empty<T>())
                .SelectMany(n => n.Flatten(childrenAccessor))
                .Prepend(root);
        }

        public static IEnumerable<T> FlattenLinage<T, TKey>(this T child, Func<T, TKey> keyAccessor, Func<T, TKey> parentKeyAccessor, ICollection<T> mainSource)
            where T : class
        {
            if (child == null)
            {
                throw new ArgumentNullException(nameof(child));
            }

            if (keyAccessor == null)
            {
                throw new ArgumentNullException(nameof(keyAccessor));
            }

            if (parentKeyAccessor == null)
            {
                throw new ArgumentNullException(nameof(parentKeyAccessor));
            }

            var parentKey = parentKeyAccessor(child);
            var parent = mainSource?.FirstOrDefault(i => keyAccessor(i).Equals(parentKey));

            if (parent == null)
                return Enumerable.Empty<T>();

            return parent
                .FlattenLinage(keyAccessor, parentKeyAccessor, mainSource)
                .Prepend(child);
        }

        #region Chunks
        public static IEnumerable<IEnumerable<T>> Chunks<T>(this IEnumerable<T> enumerable, int chunkSize)
        {
            if (chunkSize < 1)
                throw new ArgumentException($"{nameof(chunkSize)} must be strictly positive");

            using (var e = enumerable.GetEnumerator())
                while (e.MoveNext())
                {
                    var remaining = chunkSize;    // elements remaining in the current chunk
                    var innerMoveNext = new Func<bool>(() => --remaining > 0 && e.MoveNext());

                    yield return e.GetChunk(innerMoveNext);
                    while (innerMoveNext())
                    {/* discard elements skipped by inner iterator */}
                }
        }

        private static IEnumerable<T> GetChunk<T>(this IEnumerator<T> e, Func<bool> innerMoveNext)
        {
            do
                yield return e.Current;
            while (innerMoveNext());
        }
        #endregion

        #region Left outer join
        public static IEnumerable<(TLeft Left, TRight Right)> LeftJoin<TLeft, TRight, TKey>(this IEnumerable<TLeft> left, IEnumerable<TRight> right, 
            Func<TLeft, TKey> selectKeyLeft, Func<TRight, TKey> selectKeyRight)
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }

            if (selectKeyLeft == null)
            {
                throw new ArgumentNullException(nameof(selectKeyLeft));
            }

            if (selectKeyRight == null)
            {
                throw new ArgumentNullException(nameof(selectKeyRight));
            }

            return left
                .GroupJoin(right, selectKeyLeft, selectKeyRight, (l, r) => (Left: l, LeftItems: r))
                .SelectMany(i => i.LeftItems.DefaultIfEmpty(), (i, r) => (i.Left, Right: r));
        }
        #endregion

        #region Cross joins
        public static IEnumerable<(T1 Item1, T2 Item2)> Cross<T1, T2>(this IEnumerable<T1> source1, IEnumerable<T2> source2)
        {
            if (source1 == null)
            {
                throw new ArgumentNullException(nameof(source1));
            }

            if (source2 == null)
            {
                return Enumerable.Empty<(T1 Item1, T2 Item2)>();
            }

            return source1.SelectMany(i1 => source2.Select(i2 => (Item1: i1, Item2: i2)));
        }

        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3)> Cross<T1, T2, T3>(this IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3)
        {
            if (source1 == null)
            {
                throw new ArgumentNullException(nameof(source1));
            }

            if (source2 == null || source3 == null)
            {
                return Enumerable.Empty<(T1 Item1, T2 Item2, T3 Item3)>();
            }

            return source1.SelectMany(i1 => source2.SelectMany(i2 => source3.Select(i3 => (Item1: i1, Item2: i2, Item3: i3))));
        }

        public static IEnumerable<(T1 Item1, T2 Item2, T3 Item3, T4 Item4)> Cross<T1, T2, T3, T4>(this IEnumerable<T1> source1, IEnumerable<T2> source2, IEnumerable<T3> source3, IEnumerable<T4> source4)
        {
            if (source1 == null)
            {
                throw new ArgumentNullException(nameof(source1));
            }

            if (source2 == null || source3 == null || source4 == null)
            {
                return Enumerable.Empty<(T1 Item1, T2 Item2, T3 Item3, T4 Item4)>();
            }

            return source1.SelectMany(i1 => source2.SelectMany(i2 => source3.SelectMany(i3 => source4.Select(i4 => (Item1: i1, Item2: i2, Item3: i3, Item4: i4)))));
        }
        #endregion
    }
}
