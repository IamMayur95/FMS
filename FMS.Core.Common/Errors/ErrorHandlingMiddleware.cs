using System;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using FMS.Core.Common.Contracts.Errors.Exceptions;

namespace FMS.Core.Common.Errors
{
    public class ErrorHandlingMiddleware
    {
        private readonly ILogger<ErrorHandlingMiddleware> _logger;
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await _next(context);
            }
            catch (TaskCanceledException ex)
            {
                await HandleExceptionAsync(context, ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var code = StatusCodes.Status500InternalServerError;

            switch (exception)
            {
                case NotFoundException _:
                    code = StatusCodes.Status404NotFound;
                    break;

                case UnAuthorizedException _:
                    code = StatusCodes.Status401Unauthorized;
                    break;

                case ForbiddenException _:
                    code = StatusCodes.Status403Forbidden;
                    break;

                case ConflictException _:
                    code = StatusCodes.Status409Conflict;
                    break;

                case CustomException _:
                    code = StatusCodes.Status400BadRequest;
                    break;

                case OperationCanceledException _:
                    return Task.CompletedTask;
            }

            var serializationSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            var result = JsonConvert.SerializeObject(ApiResponseHelpers.FromError(exception), serializationSettings);

            context.Response.ContentType = MediaTypeNames.Application.Json;
            context.Response.StatusCode = code;

            return context.Response.WriteAsync(result);
        }
    }
}
