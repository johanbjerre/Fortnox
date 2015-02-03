using System.IO;
using System.Text;
using System.Xml.Serialization;
using Fortnox.ValueObjects.Article;
using Fortnox.ValueObjects.Articles;
using SoftHouse.Scraper;
using SoftHouse.Scraper.Interfaces;

namespace Fortnox.Helpers
{
    public static class ArticleHelper
    {
        internal static Articles GetAllArticles(string accessToken, string clientSecret, IHtmlScraper scraper = null)
        {
            var url = UrlHelper.GetAllArticles();
            if (scraper == null)
                scraper = new HtmlScraper();
            RequestHelper.MakeGetRequest(url, accessToken, clientSecret, scraper);
            var response = scraper.LastContent;

            var articles = Deserialize<Articles>(response);
            return articles;
        }

        internal static Article GetArticle(string accessToken, string clientSecret, string articleNumber, IHtmlScraper scraper = null)
        {
            var url = UrlHelper.GetArticle(articleNumber);
            if(scraper==null)
                scraper=new HtmlScraper();
            RequestHelper.MakeGetRequest(url, accessToken, clientSecret, scraper);
            var response = scraper.LastContent;

            var article = Deserialize<Article>(response);
            return article;
        }

        private static TResponse Deserialize<TResponse>(string inputString)
        {
            var serializer = new XmlSerializer(typeof(TResponse));
            var memStream = new MemoryStream(Encoding.UTF8.GetBytes(inputString));
            var output = (TResponse)serializer.Deserialize(memStream);
            return output;
        }
    }
}
