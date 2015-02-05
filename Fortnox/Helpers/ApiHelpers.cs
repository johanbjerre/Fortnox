﻿using System;
using System.Net;
using Fortnox.ValueObjects;

namespace Fortnox.Helpers
{
    public static class ApiHelpers
    {
        internal static TResponse TryWrap<TResponse>(Func<TResponse> method, string errorMessage) where TResponse : ResponseBase, new()
        {
            try
            {
                var result = method.Invoke();
                result.ErrorMessage = string.Empty;
                result.Success = true;
                return result;
            }
            catch (WebException webException)
            {
                var httpWebResponse = webException.Response as HttpWebResponse;

                if (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.BadRequest)
                    return new TResponse { ErrorMessage = HttpStatusCode.BadRequest.ToString(), Success = false };
                throw;
            }
            catch (Exception exception)
            {
                return new TResponse
                {
                    ErrorMessage = string.Format("Error:'{0}', exception message:'{1}'", errorMessage, exception.Message),
                    Success = false
                };
            }
        }

        internal static TResponse TryWrap<TRequest, TResponse>(Func<TRequest, TResponse> method, string errorMessage, TRequest request) where TResponse : ResponseBase, new()
        {
            try
            {
                var result = method.Invoke(request);
                result.ErrorMessage = string.Empty;
                result.Success = true;
                return result;
            }
            catch (Exception exception)
            {
                return new TResponse
                {
                    ErrorMessage = string.Format("Error:'{0}', exception message:'{1}'", errorMessage, exception.Message),
                    Success = false
                };
            }
        }
    }
}
