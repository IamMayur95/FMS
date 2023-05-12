using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using FMS.Core.Common.Contracts.Errors;
using System;
using System.Linq;

namespace FMS.Core.Common.Errors
{
    public static class ApiResponseHelpers
    {
        public static ApiResponse FromError<TInput>(TInput argument)
        {
            var response = new ApiResponse();

            AddErrorMessages(argument, response);

            return response;
        }

        public static ApiResponse EmptyResponse() => new ApiResponse { Succeeded = true };

        public static ApiResponse FromData<TInput>(TInput argument)
        {
            var response = new ApiResponse { Succeeded = true };

            AddData(argument, response);

            return response;
        }

        private static void AddData<TInput>(TInput argument, ApiResponse response)
        {
            if (argument is IdentityResult identityResult)
            {
                if (identityResult.Succeeded)
                {
                    response.Succeeded = true;
                }
            }
            //else if (argument is IPaginatedList<TInput> paginatedList)
            //{
            //    response.Data = paginatedList;
            //}
            else
            {
                response.Data = argument;
            }
        }

        private static void AddErrorMessages<TInput>(TInput argument, ApiResponse response)
        {
            if (argument is string error)
            {
                response.Errors.Add(error);
            }
            else if (argument is string[] errors)
            {
                response.Errors.AddRange(errors);
            }
            else if (argument is ModelStateDictionary modelState)
            {
                response.Errors = modelState.Select(m => string.Join("", m.Value.Errors.Select(e => e.ErrorMessage))).ToList();
            }
            else if (argument is IdentityResult identityResult)
            {
                if (identityResult.Succeeded)
                {
                    throw new Exception("IdentityResult can't be success in this method!");
                }
                response.Errors = identityResult.Errors.Select(ie => ie.Description).ToList();
            }
            else if (argument is Exception ex)
            {
                var message = "Internal server error";
                response.Errors.Add(message);
            }
        }

        private static string ExtractExceptionMessage(int? errorStatusCode, Exception exception)
        {
            var isInternal = errorStatusCode.HasValue &&
                              errorStatusCode.Value == StatusCodes.Status500InternalServerError;
            var message = isInternal ? "Internal server error" : GetInnerExceptionMessage(exception);
            return message;
        }

        private static string GetInnerExceptionMessage(Exception ex)
        {
            var mostInnerException = ex;
            while (mostInnerException.InnerException is not null)
            {
                mostInnerException = mostInnerException.InnerException;
            }

            return mostInnerException.Message;
        }
    }
}
