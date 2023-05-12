using System.Collections.Generic;

namespace FMS.Core.Common.Contracts.Errors
{
    public class ApiResponse
    {
        public ApiResponse() => Errors = new List<string>();

        public bool Succeeded { get; set; }
        public List<string> Errors { get; set; }
        public object Data { get; set; }
    }
}
