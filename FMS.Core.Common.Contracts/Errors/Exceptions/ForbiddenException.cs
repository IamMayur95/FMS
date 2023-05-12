using System;

namespace FMS.Core.Common.Contracts.Errors.Exceptions
{
    public class ForbiddenException : Exception
    {
        public ForbiddenException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
