using System;
using System.Linq;
using FMS.Core.Common.Contracts.Grid.Dtos;

namespace FMS.Core.Common.Filtering
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Where<T>(this IQueryable<T> source, FilterParametersDto parameters) => source.Where(parameters?.Predicate);

        public static IQueryable<T> Where<T>(this IQueryable<T> source, PredicateNodeDto predicate)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (predicate == null)
                return source;

            var lambda = new FilterExpressionBuilder().BuildLambda<T>(predicate);
            return lambda == null ? source : source.Where(lambda);
        }
    }
}
