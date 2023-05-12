using FMS.Contracts;
using FMS.Core.Common.Contracts.Configuration;
using FMS.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FMS.Services
{
    public static class IoC
    {
        public static IServiceCollection AddServices(this IServiceCollection services, ApplicationSettings appSettings)
        {
            services
                .AddTransient<IAccountService, AccountService>()
                .AddTransient<IWeatherForecastService, WeatherForecastService>()
                .AddTransient<IRequestContextService, RequestContextService>()
                .AddTransient<IMasterDataService, MasterDataService>()
                .AddTransient<IImportService, ImportService>()
                .AddTransient<IDeskService, DeskService>()
                .AddTransient<IAdminService, AdminService>()
                .AddTransient<IAnalyticsService, AnalyticsService>()
                .AddTransient<IUserService, UserService>()
                .AddTransient<IMapConfigurationService, MapConfigurationService>();

            return services;
        }

    }
}
