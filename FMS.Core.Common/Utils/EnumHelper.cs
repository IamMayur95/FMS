using FMS.Core.Common.Contracts.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace FMS.Core.Common.Utils
{
    public static class EnumHelper<TEnum>
    {
        public static List<TEnum> GetValues() => Enum.GetValues(typeof(TEnum)).Cast<TEnum>().ToList();

        public static List<T> GetIdsAndValues<T>() where T : IEnumViewModel, new()
        {
            var result = new List<T>();

            foreach (TEnum value in Enum.GetValues(typeof(TEnum)))
            {
                result.Add(new T() { Id = Convert.ToInt32(value), Text = EnumHelper<TEnum>.GetDisplayValue(value) });
            }
            return result;
        }

        private static string lookupResource(Type resourceManagerProvider, string resourceKey)
        {
            foreach (var staticProperty in resourceManagerProvider.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (staticProperty.PropertyType == typeof(System.Resources.ResourceManager))
                {
                    var resourceManager = (System.Resources.ResourceManager)staticProperty.GetValue(null, null);
                    return resourceManager.GetString(resourceKey);
                }
            }

            return resourceKey; // Fallback with the key name
        }

        public static string GetDisplayValue(TEnum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var descriptionAttributes = fieldInfo.GetCustomAttributes(
                typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes == null) return string.Empty;

            if (descriptionAttributes.Length > 0)
            {
                if (descriptionAttributes[0].ResourceType is not null)
                    return lookupResource(descriptionAttributes[0].ResourceType, descriptionAttributes[0].Name);
                else
                {
                    return descriptionAttributes[0].Name;
                }
            }
            else
            {
                return value.ToString();
            }
        }

        /// <summary>Gets the description.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="e">The enum</param>
        /// <returns>description of the enum</returns>
        public static string GetDescription<T>(T e) where T : IConvertible
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

        /// <summary>Gets the string value.</summary>
        /// <param name="value">The value.</param>
        /// <returns>string value attribute for the enum</returns>
        public static string GetStringValue(Enum value)
        {
            string output = null;
            var type = value.GetType();

            //Look for our 'StringValueAttribute'
            //in the field's custom attributes
            var fi = type.GetField(value.ToString());
            var attrs =
               fi.GetCustomAttributes(typeof(StringValueAttribute),
                                       false) as StringValueAttribute[];
            if (attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }
    }
}
