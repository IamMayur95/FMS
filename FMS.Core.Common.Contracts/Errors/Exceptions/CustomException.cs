using System;

namespace FMS.Core.Common.Contracts.Errors.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
