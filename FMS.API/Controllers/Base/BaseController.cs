using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IISIntegration;

namespace FMS.API.Controllers.Base
{
   // [Authorize(AuthenticationSchemes = IISDefaults.)]
    [Route(UriBasePrefix + "[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        public const string UriBasePrefix = "api/v1/";

        protected StatusCodeResult InternalServerError() => StatusCode(StatusCodes.Status500InternalServerError);
        protected ObjectResult InternalServerError(Exception ex) => StatusCode(StatusCodes.Status500InternalServerError, ex);
        protected ObjectResult InternalServerError(string message) => InternalServerError(new Exception(message));
    }
}
