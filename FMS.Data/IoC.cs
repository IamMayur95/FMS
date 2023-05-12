using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using FMS.Data.Contexts;
using FMS.Data.Seed;
using FMS.Data.UnitOfWork;
using Utils.Data.Interfaces;
using FMS.Core.Common.Contracts.Configuration;

namespace FMS.Data
{
    public static class IoC
    {
        // Core 3.0
        public static readonly ILoggerFactory ConsoleLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            // Make DbContext transient since we implement our own UnitOfWork pattern and will
            // let us do (with caution) parallel UnitOfWork reads (No parallel write though !!!)
            services.AddDbContext<FMSContext>((IServiceProvider sp, DbContextOptionsBuilder opt) =>
            {
                var appSettings = sp.GetRequiredService<ApplicationSettings>();
                // opt.UseMySql(appSettings.ConnectionStrings.SqlServer, ServerVersion.AutoDetect(appSettings.ConnectionStrings.SqlServer));
                // opt.UseSqlServer(appSettings.ConnectionStrings.SqlServer);
                opt.UseNpgsql(appSettings.ConnectionStrings.PostgreSql);
                opt.EnableSensitiveDataLogging(true);
            }, ServiceLifetime.Transient);

            services
                .AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>()
                .AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();

            services.AddScoped<IDbInitializer, DbInitializer>();
            services.AddScoped<UpdateDabaseIfNeededMiddleware>();
            return services;
        }

        public static void UseUpdateDatabaseIfNeeded(this IApplicationBuilder app)
        {
            app.UseMiddleware<UpdateDabaseIfNeededMiddleware>();
        }
    }
}
