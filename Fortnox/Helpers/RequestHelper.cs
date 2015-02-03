using System.Collections.Generic;
using SoftHouse.Scraper.Interfaces;
using SoftHouse.Scraper.ValueObjects;

namespace Fortnox.Helpers
{
    public class RequestHelper
    {
        public static string MakeGetRequest(string url, string AccessToken, string ClientSecret, IHtmlScraper scraper)
        {
            return MakeRequest(url, null, AccessToken, ClientSecret, scraper);
        }

        public static string MakePostRequest(string url, string postdata, string AccessToken, string ClientSecret, IHtmlScraper scraper)
        {
            return MakeRequest(url, postdata, AccessToken, ClientSecret, scraper);
        }

        private static string MakeRequest(string url, string postdata, string AccessToken, string ClientSecret,
                                        IHtmlScraper scraper)
        {
            var headers = new List<Header>
                {
                    new Header {HeaderName = "Access-Token", HeaderValue = AccessToken},
                    new Header {HeaderName = "Client-Secret", HeaderValue = ClientSecret}
                };
            return scraper.PerformRequest(url, postdata, null, Constants.FortnoxConstants.CONTENT_TYPE,
                                   Constants.FortnoxConstants.ACCEPT, headers);
        }


        //private static void PreparePostRequest(ref HttpWebRequest httpWebRequest, string postdata)
        //{
        //    httpWebRequest.Method = "POST";
        //    //httpWebRequest.ContentType = "application/x-www-form-urlencoded";
        //    var bytes = Encoding.UTF8.GetBytes(postdata);
        //    httpWebRequest.ContentLength = bytes.Length;
        //    var requestStream = httpWebRequest.GetRequestStream();
        //    requestStream.Write(bytes, 0, bytes.Length);
        //}

        //private static void PrepareGetRequest(ref HttpWebRequest httpWebRequest)
        //{
        //    httpWebRequest.Method = "GET";
        //}

        //private static void PrepareFortnoxCredentials(ref HttpWebRequest httpWebRequest, string AccessToken, string ClientSecret)
        //{
        //    httpWebRequest.Headers.Add("Access-Token", AccessToken);
        //    httpWebRequest.Headers.Add("Client-Secret", ClientSecret);
        //}
    }
}

