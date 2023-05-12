using System.Reflection;

namespace FMS.Core.Common.Utils
{
    public static class ReflexionTools
    {

        public static string ExactCasingPublicPropertyName<T>(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                return null;
            }

            var p = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            return p?.Name;
        }
    }
}
