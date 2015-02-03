namespace Fortnox.Helpers
{
    public static class UrlHelper
    {
        internal static string GetAllArticles()
        {
            const string url = Constants.FortnoxConstants.HOST + "articles";
            return url;
        }

        internal static string GetArticle(string articleNumber)
        {
            var url = Constants.FortnoxConstants.HOST + "articles" + "/" + articleNumber;
            return url;
        }
    }
}
