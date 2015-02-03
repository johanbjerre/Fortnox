using System;
using Fortnox.Helpers;
using Fortnox.ValueObjects;
using Fortnox.ValueObjects.Article;
using Fortnox.ValueObjects.Articles;

namespace Fortnox
{
    public static class ApiArticle
    {
        public static Articles GetAllArticles(string accessToken, string clientSecret)
        {
            return TryWrap(() => ArticleHelper.GetAllArticles(accessToken, clientSecret,null), "Unable to get all articles");
        }

        public static Article GetArticle(string accessToken, string clientSecret, string articleNumber)
        {
            return TryWrap(() => ArticleHelper.GetArticle(accessToken, clientSecret, articleNumber, null),
                           string.Format("Unable to get article with number '{0}'", articleNumber));
        }

        private static TResponse TryWrap<TResponse>(Func<TResponse> method, string errorMessage) where TResponse : ResponseBase, new()
        {
            try
            {
                var result = method.Invoke();
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

        private static TResponse TryWrap<TRequest, TResponse>(Func<TRequest, TResponse> method, string errorMessage, TRequest request) where TResponse : ResponseBase, new()
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
