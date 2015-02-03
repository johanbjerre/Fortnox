using System.Collections.Generic;
using SoftHouse.Scraper.Interfaces;
using SoftHouse.Scraper.ValueObjects;

namespace Fortnox.Helpers
{
    internal class RequestHelper
    {
        internal static string MakeGetRequest(string url, string accessToken, string clientSecret, IHtmlScraper scraper)
        {
            return MakeRequest(url, null, accessToken, clientSecret, scraper);
        }

        internal static string MakePostRequest(string url, string postdata, string accessToken, string clientSecret, IHtmlScraper scraper)
        {
            return MakeRequest(url, postdata, accessToken, clientSecret, scraper);
        }

        private static string MakeRequest(string url, string postdata, string accessToken, string clientSecret,
                                        IHtmlScraper scraper)
        {
            var headers = new List<Header>
                {
                    new Header {HeaderName = Constants.FortnoxConstants.ACCESS_TOKEN, HeaderValue = accessToken},
                    new Header {HeaderName = Constants.FortnoxConstants.CLIENT_SECRET, HeaderValue = clientSecret}
                };
            return scraper.PerformRequest(url, postdata, null, Constants.FortnoxConstants.CONTENT_TYPE,
                                   Constants.FortnoxConstants.ACCEPT, headers);
        }
    }
}

