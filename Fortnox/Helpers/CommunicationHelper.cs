﻿using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Fortnox.ValueObjects;
using Fortnox.ValueObjects.Account;
using Fortnox.ValueObjects.Accounts;
using Fortnox.ValueObjects.Article;
using Fortnox.ValueObjects.Articles;
using SoftHouse.Scraper;
using SoftHouse.Scraper.Interfaces;

namespace Fortnox.Helpers
{
    public static class CommunicationHelper
    {
        internal static Articles GetAllArticles(string accessToken, string clientSecret, IHtmlScraper scraper = null)
        {
            var url = UrlHelper.GetAllArticles();
            return Get<Articles>(url, accessToken, clientSecret, scraper);
        }

        internal static Article GetArticle(string accessToken, string clientSecret, string number, IHtmlScraper scraper = null)
        {
            var url = UrlHelper.GetArticle(number);
            return Get<Article>(url, accessToken, clientSecret, scraper);
        }

        internal static Accounts GetAllAccounts(string accessToken, string clientSecret, IHtmlScraper scraper = null)
        {
            var url = UrlHelper.GetAllAccounts();
            return Get<Accounts>(url, accessToken, clientSecret, scraper);
        }

        internal static Account GetAccount(string accessToken, string clientSecret, string number, IHtmlScraper scraper = null)
        {
            var url = UrlHelper.GetAccount(number);
            return Get<Account>(url, accessToken, clientSecret, scraper);
        }

        private static TResponse Get<TResponse>(string url, string accessToken, string clientSecret,
                                                IHtmlScraper scraper = null) where TResponse : ResponseBase, new()
        {
            if (scraper.IsNull())
                scraper = new HtmlScraper();

            RequestHelper.MakeGetRequest(url, accessToken, clientSecret, scraper);

            var response = scraper.LastContent;
            var deserialized = Deserialize<TResponse>(response);
            return deserialized;
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
