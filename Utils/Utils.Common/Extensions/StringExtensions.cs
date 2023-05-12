using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Utils.Common.Extensions
{
    public static class StringExtensions
    {
        public static string SplitCamelCase(this string @this, string delimeter = " ")
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            return @this.Any(char.IsUpper)
                ? string.Join(delimeter, Regex.Split(@this, "(?<!^)(?=[A-Z])"))
                : @this;
        }
    }
}
