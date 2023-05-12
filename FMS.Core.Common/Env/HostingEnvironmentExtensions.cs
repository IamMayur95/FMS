using System;

using Microsoft.AspNetCore.Hosting;

namespace FMS.Core.Common.Env
{
    public static class HostingEnvironmentExtensions
    {
        public static bool IsLocal(this IWebHostEnvironment hostingEnvironment)
        {
            if (hostingEnvironment == null)
            {
                throw new ArgumentNullException(nameof(hostingEnvironment));
            }

            return string.IsNullOrEmpty(hostingEnvironment.EnvironmentName);
        }

        public static bool IsExplicitLocal(this IWebHostEnvironment hostingEnvironment)
        {
            if (hostingEnvironment == null)
            {
                throw new ArgumentNullException(nameof(hostingEnvironment));
            }

            return hostingEnvironment.EnvironmentName.Equals(RomEnvironmentName.Local) 
                || hostingEnvironment.EnvironmentName.Equals(Environment.MachineName);
        }
    }
}
