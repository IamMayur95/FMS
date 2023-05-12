using FMS.Contracts;
using FMS.Core.Common.Utils;
using FMS.Entities.DTOs;
using System;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace FMS.API.Controllers.Base
{
    public abstract class BaseArgsController : BaseController
    {

        private readonly IRequestContextService _requestContextService;

        protected BaseArgsController(IRequestContextService requestContextService) : base()
        {
            _requestContextService = requestContextService;
        }

        protected BaseArgs GetArgsAsync()
        {
            //First get user claims    
            var user = HttpContext.User;

            if (user == null || user.Identity == null || string.IsNullOrWhiteSpace(user.Identity.Name) || !user.Identity.IsAuthenticated)
                throw new ArgumentException("User must be authenticated");

            //Filter specific claim    
            var userDetails = user.Identity.Name.Split('|');
            var args = new BaseArgs()
            {
                EmployeeId = userDetails[0],
                FullName = userDetails[1],
                UserId = Convert.ToInt32(userDetails[2]),
                Email = userDetails[4]
            };

            return args;
        }

        protected async Task<bool> SetActiveArgsAsync(BaseArgs args)
            => await _requestContextService.SetActiveArgsAsync(args);

    }
}