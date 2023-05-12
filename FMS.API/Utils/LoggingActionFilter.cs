using System;
using System.Threading.Tasks;
using FMS.Core.Common.Contracts.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace FMS.API.Utils
{
    public class LoggingActionFilter : IAsyncActionFilter
    {
        private readonly ILogger<LoggingActionFilter> _logger;

        public LoggingActionFilter(ILogger<LoggingActionFilter> logger)
        {
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.Controller is not ControllerBase controllerBase)
            {
                throw new ArgumentException($"Filter '{nameof(LoggingActionFilter)}' can only be called on controllers inheriting {nameof(ControllerBase)}");
            }

            var controllerName = controllerBase.ControllerContext.ActionDescriptor.ControllerName;
            var actionName = controllerBase.ControllerContext.ActionDescriptor.ActionName;

            var logMessage = $"Controller.Action: {controllerName}.{actionName}";
            _logger.LogInformation(LoggingEvents.ActionsLogging, logMessage);

            await next();
        }
    }
}
