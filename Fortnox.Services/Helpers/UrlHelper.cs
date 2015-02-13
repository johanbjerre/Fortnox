using System.Linq;
using Fortnox.Services.Constants;

namespace Fortnox.Services.Helpers
{
    public static class UrlHelper
    {
        public static string GetAllArticles()
        {
            return ExtendBaseUrl(FortnoxConstants.ARTICLES);
        }

        public static string GetArticle(string number)
        {
            return ExtendBaseUrl(FortnoxConstants.ARTICLES, number);
        }

        public static string GetAllAccounts()
        {
            return ExtendBaseUrl(FortnoxConstants.ACCOUNTS);
        }

        public static string GetAccount(string number)
        {
            return ExtendBaseUrl(FortnoxConstants.ACCOUNTS, number);
        }

        private static string ExtendBaseUrl(params string[] parts)
        {
            var output = parts.Aggregate(FortnoxConstants.HOST,
                                         (current, part) => current + FortnoxConstants.DIRECTORY_SEPARATOR + part);
            return output;
        }
    }
}
