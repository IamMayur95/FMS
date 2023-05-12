using FMS.API.Controllers.Base;
using FMS.Contracts;
using FMS.Entities.DTOs;
using FMS.Services.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IConfiguration = Microsoft.Extensions.Configuration.IConfiguration;

namespace FMS.API.Controllers
{
    public class NotificationController : BaseArgsController
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;
        private readonly IConfiguration _configuration;
        private IHubContext<NotifyHub, ITypedHubClient> _hubContext;

        public NotificationController(IRequestContextService requestContextService,
        ILogger<AccountController> logger,
        IAccountService accountService, IConfiguration configuration,
        IHubContext<NotifyHub, ITypedHubClient> hubContext) : base(requestContextService)
        {
            _logger = logger;
            _accountService = accountService;
            _configuration = configuration;
            _hubContext = hubContext;
        }

        [HttpPost("[action]")]
        public async Task<bool> PublishEvent(PublishEventData eventData, CancellationToken cancellationToken)
        {
            bool retMessage = false;

            try
            {
                await _hubContext.Clients.All.BroadcastMessage(eventData);
                retMessage = true;
            }
            catch (Exception e)
            {
                retMessage = false;
            }
            return retMessage;
        }
    }
}
