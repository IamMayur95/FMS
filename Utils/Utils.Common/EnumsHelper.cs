using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using Utils.Common.Extensions;

namespace Utils.Common
{
    public static class Enums
    {
        public static IEnumerable<TEnum> GetValues<TEnum>()
            where TEnum : Enum
            => Enum.GetValues(typeof(TEnum)).Cast<TEnum>();

        public static IEnumerable<TEnum> ToEnum<TEnum>(this IEnumerable<string> @this)
            where TEnum : Enum
        {
            if (@this == null)
                throw new ArgumentNullException(nameof(@this));

            return @this
                .Select(s => Enum.TryParse(typeof(TEnum), s, out var e) ? e : null)
                .Where(e => e is not null)
                .Cast<TEnum>();
        }

        public static string GetDescription<T>(this T e) where T : Enum, IConvertible
        {
            if (e is Enum)
            {
                var type = e.GetType();
                var values = Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));

                        if (memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() is DescriptionAttribute descriptionAttribute)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }

            return string.Empty;
        }
    }
}
