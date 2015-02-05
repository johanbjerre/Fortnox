using System.Linq;
using Fortnox.Constants;

namespace Fortnox.Helpers
{
    public static class UrlHelper
    {
        internal static string GetAllArticles()
        {
            return ExtendBaseUrl(FortnoxConstants.ARTICLES);
        }

        internal static string GetArticle(string number)
        {
            return ExtendBaseUrl(FortnoxConstants.ARTICLES, number);
        }

        internal static string GetAllAccounts()
        {
            return ExtendBaseUrl(FortnoxConstants.ACCOUNTS);
        }

        internal static string GetAccount(string number)
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
