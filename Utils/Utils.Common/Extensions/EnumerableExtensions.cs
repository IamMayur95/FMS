using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using Utils.Common.Interfaces;

namespace Utils.Common.Extensions
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

        public static IEnumerable<T> IsNotNull<T>(this IEnumerable<T> @this)
             => @this?.Where(i => i is not null) ?? throw new ArgumentNullException(nameof(@this));

        public static IEnumerable<(TLeft LeftValue, TRight RightValue)> JoinOnId<TLeft, TRight>(this IEnumerable<TLeft> @this, IEnumerable<TRight> inner)
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

        public static IEnumerable<T> Except<T>(this IEnumerable<T> listA, IEnumerable<T> listB, Func<T, T, bool> lambda)
        {
            return listB == null ? listA : listA.Except(listB, new LambdaEqualityComparer<T>(lambda));
        }

        public static IEnumerable<T> Unbox<T>(this IEnumerable<T?> @this)
            where T : struct
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            return @this.Where(i => i is not null).Select(i => i.Value);
        }

        public static IEnumerable<(T PreviousOrDefault, T Current)> SelectWithPrevious<T>(this IEnumerable<T> @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            using var iterator = @this.GetEnumerator();
            if (!iterator.MoveNext())
                yield break;

            yield return (default, iterator.Current);

            var previous = iterator.Current;
            while (iterator.MoveNext())
            {
                yield return (previous, iterator.Current);
                previous = iterator.Current;
            }
        }

        public static IEnumerable<TResult> SelectWithPrevious<T, TResult>(this IEnumerable<T> @this, Func<T, T, TResult> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return @this
                .SelectWithPrevious()
                .Select(o => selector(o.PreviousOrDefault, o.Current));
        }

        public static IEnumerable<(T Current, T NextOrDefault)> SelectWithNext<T>(this IEnumerable<T> @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            using var iterator = @this.GetEnumerator();
            if (!iterator.MoveNext())
                yield break;

            var current = iterator.Current;
            while (iterator.MoveNext())
            {
                yield return (current, iterator.Current);
                current = iterator.Current;
            }

            yield return (current, default);
        }

        public static IEnumerable<TResult> SelectWithNext<T, TResult>(this IEnumerable<T> @this, Func<T, T, TResult> selector)
        {
            if (selector == null)
                throw new ArgumentNullException(nameof(selector));

            return @this
                .SelectWithNext()
                .Select(o => selector(o.Current, o.NextOrDefault));
        }

        public static (T, T) FirstTupleOrDefault<T>(this IEnumerable<T> @this, Func<T, bool> firstFieldPredicate, Func<T, bool> secondFieldPredicate)
		{
            if (firstFieldPredicate == null)
                throw new ArgumentNullException(nameof(firstFieldPredicate));
            if (secondFieldPredicate == null)
                throw new ArgumentNullException(nameof(secondFieldPredicate));

            var result = (default(T), default(T));
            var state = (false, false);
            using var enumerator = @this.GetEnumerator();
            while(enumerator.MoveNext())
			{
                var current = enumerator.Current;

                if (firstFieldPredicate(current))
				{
                    result.Item1 = current;
                    state.Item1 = true;
				}

                if (secondFieldPredicate(current))
				{
                    result.Item2 = current;
                    state.Item2 = true;
				}

                if (state == (true, true))
                    return result;
			}
            return (default(T), default(T));
        }

        public static T UniqueOrDefault<T>(this IEnumerable<T> @this)
		{
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            using var enumerator = @this.GetEnumerator();
            if (!enumerator?.MoveNext() ?? true)
                return default;

            var current = enumerator.Current;
            return enumerator.MoveNext()
                ? default
                : current;
        }

        #region OrderBy / ThenBy
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> @this, Func<TSource, TKey> keySelector, ListSortDirection direction)
            => @this.OrderBy(keySelector, direction == ListSortDirection.Descending);

        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> @this, Func<TSource, TKey> keySelector, bool descending)
            => (descending ? @this?.OrderByDescending(keySelector) : @this?.OrderBy(keySelector)) ?? throw new ArgumentNullException(nameof(@this));

        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> @this, Func<TSource, TKey> keySelector, ListSortDirection direction)
            => @this.ThenBy(keySelector, direction == ListSortDirection.Descending);

        public static IOrderedEnumerable<TSource> ThenBy<TSource, TKey>(this IOrderedEnumerable<TSource> @this, Func<TSource, TKey> keySelector, bool descending)
            => (descending ? @this?.ThenByDescending(keySelector) : @this?.ThenBy(keySelector)) ?? throw new ArgumentNullException(nameof(@this));
        #endregion

        #region Random
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> @this)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            var seed = DateTime.UtcNow.Millisecond + Guid.NewGuid().GetHashCode(); // to ensure parallel-threads seed uniqueness
            var random = new Random(seed);
            return @this.OrderBy(s => random.NextDouble()); 
        }

        public static T Pick<T>(this IEnumerable<T> @this)
        {
            return @this.Shuffle().FirstOrDefault();
        }
        #endregion

        #region Recursive helpers
        public static IEnumerable<T> Flatten<T>(this T root, Func<T, IEnumerable<T>> childrenAccessor)
        {
            if (root == null)
                throw new ArgumentNullException(nameof(root));

            if (childrenAccessor == null)
                throw new ArgumentNullException(nameof(childrenAccessor));

            return (childrenAccessor(root) ?? Enumerable.Empty<T>())
                .SelectMany(n => n.Flatten(childrenAccessor))
                .Prepend(root); // must be last otherwise recursion is infinite...
        }

        public static IEnumerable<T> Flatten<T>(this T root)
            where T : IHasRecursiveStructure<T>
        {
            return root.Flatten(i => i.Children);
        }

        public static bool RemoveBranch<T>(this T root, T branch)
            where T : IHasRecursiveStructure<T>
        {
            if (root == null)
                throw new ArgumentNullException(nameof(root));

            if (root.Children == null || root.Children.Count == 0)
                return false;

            var removed = root.Children.Remove(branch)
                || root.Children.Any(n => n.RemoveBranch(branch));

            return removed;
        }

        public static IEnumerable<T> FlattenLinage<T, TKey>(this T @this, Func<T, TKey> keyAccessor, Func<T, TKey> parentKeyAccessor, ICollection<T> mainSource)
            where T : class
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            if (keyAccessor == null)
            {
                throw new ArgumentNullException(nameof(keyAccessor));
            }

            if (parentKeyAccessor == null)
            {
                throw new ArgumentNullException(nameof(parentKeyAccessor));
            }

            var parentKey = parentKeyAccessor(@this);
            var parent = mainSource?.FirstOrDefault(i => keyAccessor(i).Equals(parentKey));

            if (parent == null)
                return Enumerable.Empty<T>();

            return parent
                .FlattenLinage(keyAccessor, parentKeyAccessor, mainSource)
                .Prepend(@this);
        }

        public static IEnumerable<T> FlattenLinage<T>(this T @this, ICollection<T> mainSource)
            where T : class, IHasRecursiveStructure
        {
            return @this.FlattenLinage(i => i.Id, i => i.ParentId, mainSource);
        }

        public static T BuildTree<T>(this IEnumerable<T> @this, Func<T, int> keyAccessor, Func<T, int?> parentKeyAccessor, Action<T, ICollection<T>> childrenSetter, int? rootId = null)
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            if (keyAccessor == null)
            {
                throw new ArgumentNullException(nameof(keyAccessor));
            }

            if (parentKeyAccessor == null)
            {
                throw new ArgumentNullException(nameof(parentKeyAccessor));
            }

            if (childrenSetter == null)
            {
                throw new ArgumentNullException(nameof(childrenSetter));
            }

            var allByParentId = @this.ToLookup(parentKeyAccessor);
            var roots = allByParentId[rootId].ToList();

            if (roots.Count == 0)
            {
                return default;
            }
            else if (roots.Count > 1)
            {
                throw new ArgumentException($"Source enumerable can contain only one root node (id == {rootId}): {roots.Count} found");
            }

            // local recursive function (uses local closure for simplicity)
            void assignChildrenRec(T node)
            {
                var children = allByParentId[keyAccessor(node)].ToList();
                childrenSetter(node, children);
                foreach (var child in children)
                {
                    assignChildrenRec(child);
                }
            };

            var root = roots[0];
            assignChildrenRec(root);

            return root;
        }

        public static T BuildTree<T>(this IEnumerable<T> @this, int? rootId = null)
            where T : IHasRecursiveStructure<T>
        {
            return @this.BuildTree(i => i.Id, i => i.ParentId, (i, list) => i.Children = list, rootId);
        }

        public static T BuildTree<T>(this T @this, ICollection<T> feed)
            where T : IHasRecursiveStructure<T>
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            if (feed == null || feed.Count == 0)
                return @this;

            var t = feed.BuildTree(@this.Id);
            @this.Children = t.Children; // we could return 't' but safer in case caller cloned the node with Id == rootId

            return @this;
        }

        public static T FirstOrDefault<T, TKey>(this T @this, Func<T, TKey> keyAccessor, Func<T, IEnumerable<T>> childrenAccessor, TKey key)
            where T : class
        {
            if (@this == null)
            {
                throw new ArgumentNullException(nameof(@this));
            }

            if (keyAccessor == null)
            {
                throw new ArgumentNullException(nameof(keyAccessor));
            }

            if (childrenAccessor == null)
            {
                throw new ArgumentNullException(nameof(childrenAccessor));
            }

            return Equals(keyAccessor(@this), key)
                ? @this
                : childrenAccessor(@this)?.FirstOrDefault()?.FirstOrDefault(keyAccessor, childrenAccessor, key);
        }

        public static T FirstOrDefault<T>(this T @this, int key)
            where T : class, IHasRecursiveStructure<T>
        {
            return @this.FirstOrDefault(i => i.Id, i => i.Children, key);
        }
        #endregion

        #region Chunks
        public static IEnumerable<IEnumerable<T>> Chunks<T>(this IEnumerable<T> enumerable, int chunkSize)
        {
            if (chunkSize < 1)
                throw new ArgumentException($"{nameof(chunkSize)} must be strictly positive");

            using var e = enumerable.GetEnumerator();
            while (e.MoveNext())
            {
                var remaining = chunkSize;    // elements remaining in the current chunk
                var innerMoveNext = new Func<bool>(() => --remaining > 0 && e.MoveNext());

                yield return e.GetChunk(innerMoveNext);
                while (innerMoveNext())
                {/* discard elements skipped by inner iterator */}
            }
        }

        private static IEnumerable<T> GetChunk<T>(this IEnumerator<T> e,
            Func<bool> innerMoveNext)
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
