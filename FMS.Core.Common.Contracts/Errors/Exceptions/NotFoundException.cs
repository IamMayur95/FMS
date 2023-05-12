using System;

namespace FMS.Core.Common.Contracts.Errors.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message = "Resource not found.") : base(message)
        {
        }
    }
}
