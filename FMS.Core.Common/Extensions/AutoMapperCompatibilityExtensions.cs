using AutoMapper;

using System;

namespace FMS.Core.Common.Extensions
{
    /// <summary>
    ///
    /// </summary>
    public static class AutoMapperCompatibilityExtensions
    {
        /// <summary>
        /// Resolve destination member using a custom value resolver callback.Used instead
        ///     of MapFrom when not simply redirecting a source member This method cannot be
        ///     used in conjunction with LINQ query projection
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <typeparam name="TMember"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="member"></param>
        /// <param name="resolver">Callback function to resolve against source type</param>
        public static void ResolveUsing<TSource, TDestination, TMember, TResult>(this IMemberConfigurationExpression<TSource, TDestination, TMember> member, Func<TSource, TResult> resolver) => member.MapFrom((Func<TSource, TDestination, TResult>)((src, dest) => resolver(src)));
    }
}
