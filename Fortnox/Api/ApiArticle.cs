using Fortnox.Services.Helpers;
using Fortnox.Services.ValueObjects.Article;
using Fortnox.Services.ValueObjects.Articles;

// ReSharper disable CheckNamespace
namespace Fortnox
// ReSharper restore CheckNamespace
{
    public static class ApiArticle
    {
        public static Articles ListAll(string accessToken, string clientSecret)
        {
            return ApiHelpers.TryWrap(() => CommunicationHelper.GetAllArticles(accessToken, clientSecret),
                                      "Unable to get all articles");
        }

        public static Article Retrieve(string accessToken, string clientSecret, string number)
        {
            return ApiHelpers.TryWrap(() => CommunicationHelper.GetArticle(accessToken, clientSecret, number),
                           string.Format("Unable to get article with number '{0}'", number));
        }
    }
}
