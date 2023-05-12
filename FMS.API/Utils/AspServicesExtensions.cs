using System;
using System.Reflection;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using FMS.API.Utils;
using FMS.Core.Common.Contracts.Configuration;
using FMS.Core.Services;
using FMS.Data.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace FMS.API.Utils
{
    public static class AspServicesExtensions
    {
        public static IServiceCollection AddFMSMvc(this IServiceCollection services)
        {
            services.AddMvc(o =>
            {
                o.Filters.Add<LoggingActionFilter>();
            })
               .AddNewtonsoftJson(
                   options =>
                   {
                       options.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
                       options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                       options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                       options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
                       options.SerializerSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                   })
               .SetCompatibilityVersion(CompatibilityVersion.Latest)
               .ConfigureApiBehaviorOptions(options =>
               {
                   options.SuppressMapClientErrors = true;
               });

            return services;
        }

        public static IServiceCollection AddSecurity(this IServiceCollection services, string corsPolicyName, string clientUrl)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: corsPolicyName,
                    builder =>
                    {
                        //if (string.IsNullOrWhiteSpace(clientUrl))
                        //    builder.AllowAnyOrigin();
                        //else
                        //    builder.WithOrigins(clientUrl);

                        builder
                            .WithOrigins(clientUrl)
                            .AllowAnyHeader()
                            .WithMethods("GET", "HEAD", "POST", "PUT", "DELETE", "OPTIONS")
                            .AllowCredentials(); // The CORS protocol does not allow specifying a wildcard(any) origin and credentials at the same time.Configure the CORS policy by listing individual origins if credentials needs to be supported.
                    });
            });

            services.AddHsts(options =>
            {
                options.Preload = true;
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromMinutes(60);
            });

            return services;
        }

        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services
                .AddAutoMapper((serviceProvider, config) =>
                {
                    config.AddCollectionMappers();
                    config.UseEntityFrameworkCoreModel<FMSContext>(serviceProvider);
                },
                typeof(BaseService).GetTypeInfo().Assembly,
                typeof(AspServicesExtensions).GetTypeInfo().Assembly);

            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services, ApplicationSettings appSettings)
        {
            services.AddSwaggerGen(c =>
            {
                c.CustomOperationIds(e =>
                {
                    var controllerName = e.ActionDescriptor.RouteValues["controller"];
                    var actionName = e.ActionDescriptor.RouteValues["action"];
                    return $"{controllerName}_{actionName}";
                });

                c.SwaggerDoc("fms", new OpenApiInfo { Title = "FMS", Version = "v1" });
            });

            services.AddSwaggerGenNewtonsoftSupport();

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {

            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/fms/swagger.json", "FMS"));
            //app.UseSwagger(options => { options.SerializeAsV2 = false; });

            return app;
        }
    }
}
