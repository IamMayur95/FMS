using System;
using System.Reflection;

namespace Utils.Common.Extensions
{
    public static class TypeExtensions
    {
        public static string FindExactCasingPublicPropertyName(this Type @this, string propertyName)
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            if (string.IsNullOrWhiteSpace(propertyName))
                return null;

            var p = @this.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            return p?.Name;
        }
    }
}
