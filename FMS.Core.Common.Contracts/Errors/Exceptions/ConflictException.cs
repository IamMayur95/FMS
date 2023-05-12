using System;

namespace FMS.Core.Common.Contracts.Errors.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
