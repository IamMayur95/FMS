using System;
using System.Linq;

namespace FMS.Core.Common.Extensions
{
    public static class AttributeExtensions
    {
        public static bool ContainsAttribute<TAttribute>(
            this Type type)
            where TAttribute : Attribute
        {
            return type.GetCustomAttributes(typeof(TAttribute), false)
                .Any(t => t is TAttribute);
        }
    }
}
