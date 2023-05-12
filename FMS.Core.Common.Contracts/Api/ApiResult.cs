using System.Collections.Generic;

namespace FMS.Core.Common.Contracts.Api
{
    public class ApiResult
    {
        public ApiResult() => Errors = new List<string>();

        public ApiResult(ApiStatusCode statusCode) => StatusCodeEnum = statusCode;

        public bool Succeeded { get; set; }

        public List<string> Errors { get; set; }
        public string StatusCode => StatusCodeEnum.ToString();
        public ApiStatusCode StatusCodeEnum { get; set; }

        public object Data { get; set; }
    }
}
