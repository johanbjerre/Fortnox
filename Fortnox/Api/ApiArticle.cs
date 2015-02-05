using Fortnox.Helpers;
using Fortnox.ValueObjects.Article;
using Fortnox.ValueObjects.Articles;

namespace Fortnox.Api
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
