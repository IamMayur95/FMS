using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using FMS.Core.Common.Extensions;
using Utils.Data.Interfaces;

namespace FMS.Data.Seed
{
    internal class UpdateDabaseIfNeededMiddleware : IMiddleware
    {
        private static readonly ConcurrentDictionary<Guid, bool> _initializationLog = new();
        private static readonly object _lock = new();
        private readonly IServiceProvider _serviceProvider;

        public UpdateDabaseIfNeededMiddleware(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            lock (_lock)
            {
                var dbInitialzer = _serviceProvider.GetRequiredService<IDbInitializer>();
                dbInitialzer.MigrateAndSeedIfNeededAsync().GetAwaiter().GetResult();
            }

            return next.Invoke(context);
        }
    }
}
