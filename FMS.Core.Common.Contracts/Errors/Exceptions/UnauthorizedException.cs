using System;

namespace FMS.Core.Common.Contracts.Errors.Exceptions
{
    public class UnAuthorizedException : Exception
    {
        public UnAuthorizedException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
