using System;

namespace FMS.Core.Common.Utils
{
    public static class Guard
    {
        public static void CheckNotNull(object instance, string parameterName)
        {
            if (instance == null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }
    }
}
