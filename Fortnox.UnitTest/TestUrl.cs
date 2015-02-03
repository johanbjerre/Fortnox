﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Fortnox.Helpers;
using Fortnox.ValueObjects.Article;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using NMock.Actions;
using SoftHouse.Scraper.Interfaces;
using SoftHouse.Scraper.ValueObjects;

namespace Fortnox.UnitTest
{
    [TestClass]
    public class TestUrl
    {
        private Mock<IHtmlScraper> _htmlScraper;
        private string _contentType;
        private string _accept;
        private List<Header> _headers;
        private string _article1;

        [TestInitialize]
        public void TestInit()
        {
            var mockFactory = new MockFactory();
            _htmlScraper = mockFactory.CreateMock<IHtmlScraper>();
            _contentType = SoftHouse.Scraper.Constants.RequestConstants.CONTENT_TYPE_XML;
            _accept = SoftHouse.Scraper.Constants.RequestConstants.ACCEPT_XML;
            _headers = new List<Header>
                {
                    new Header {HeaderName = Constants.FortnoxConstants.ACCEPT_TOKEN, HeaderValue = "abc"},
                    new Header {HeaderName = Constants.FortnoxConstants.CLIENT_SECRET, HeaderValue = "def"}
                };
            _article1 = @"<?xml version='1.0' encoding='UTF-8'?><Article url='https://api.fortnox.se/3/articles/1'><ArticleNumber>1</ArticleNumber><Bulky>false</Bulky><ConstructionAccount>0</ConstructionAccount><Depth></Depth><Description>Fortnox Bokföring</Description><DisposableQuantity>144</DisposableQuantity><EAN>125544</EAN><EUAccount>3018</EUAccount><EUVATAccount>3016</EUVATAccount><ExportAccount>3015</ExportAccount><Height></Height><Housework>false</Housework><Manufacturer></Manufacturer><ManufacturerArticleNumber></ManufacturerArticleNumber><Note></Note><PurchaseAccount>4011</PurchaseAccount><PurchasePrice>100</PurchasePrice><QuantityInStock>146</QuantityInStock><ReservedQuantity>2</ReservedQuantity><SalesAccount>3011</SalesAccount><StockGoods>true</StockGoods><StockPlace>102A</StockPlace><StockValue>14600</StockValue><StockWarning></StockWarning><SupplierName></SupplierName><SupplierNumber></SupplierNumber><Type>STOCK</Type><Unit></Unit><VAT>25</VAT><WebshopArticle>true</WebshopArticle><Weight>200</Weight><Width></Width><Expired>false</Expired></Article>";
        }


        [TestMethod]
        public void TestGetArticleFlow()
        {
            var articleNumber = "1";
            var url = "https://api.fortnox.se/3/article/" + articleNumber;
            //var path = GetAbsolutePath(@"Article1.xml");
            //var streamReader = new StreamReader(path);
            //var inputContentStartsidaSp = streamReader.ReadToEnd();
            //streamReader.Close();
            var inputContentStartsidaSp = _article1;
            _htmlScraper.Expects.AtLeast(0).GetProperty(d => d.LastContent).WillReturn(inputContentStartsidaSp);
            _htmlScraper.Expects.AtLeast(0).Method(d => d.PerformRequest(url, null, null, null, null, null)).WithAnyArguments().WillReturn("");

            var obj = new PrivateType(typeof(ArticleHelper));
            var args = new object[] { "abc", "def", "1", _htmlScraper.MockObject };
            var response = (Article)obj.InvokeStatic("GetArticle", args);
            Assert.AreEqual(articleNumber, response.ArticleNumber);
        }

        [TestMethod]
        public void TestGetAllArticles()
        {
            var expected = "https://api.fortnox.se/3/articles";
            var obj = new PrivateType(typeof(UrlHelper));
            var result = obj.InvokeStatic("GetAllArticles");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestGetArticle()
        {
            var expected = "https://api.fortnox.se/3/articles/123";
            const string articleNumber = "123";
            var obj = new PrivateType(typeof(UrlHelper));
            var args = new object[] { articleNumber };
            var result = obj.InvokeStatic("GetArticle", args);
            Assert.AreEqual(expected, result);
        }

        public static string GetAbsolutePath(string relativePath)
        {
            if (relativePath.StartsWith("\\\\") || !(relativePath.StartsWith("..") || relativePath.StartsWith("\\")))
                return relativePath;

            var appPath = AppDomain.CurrentDomain.BaseDirectory;
            var appPathDirectories = appPath.Split(Path.DirectorySeparatorChar);
            var relativePathDirectories = relativePath.Split(Path.DirectorySeparatorChar);
            var appPathIndex = appPathDirectories.Length - 1;
            var resultPath = string.Empty;

            foreach (var relativePathDirectory in relativePathDirectories)
            {
                if (relativePathDirectory == "..")
                {
                    appPathIndex -= 1;
                    continue;
                }
                resultPath += string.Format("\\{0}", relativePathDirectory);
            }

            while (resultPath.StartsWith("\\"))
                resultPath = resultPath.Substring(1);

            for (int i = appPathIndex; i >= 0; i--)
            {
                if (!(appPathDirectories[i] == null || appPathDirectories[i] == ""))
                    resultPath = string.Format("{0}\\{1}", appPathDirectories[i], resultPath);
            }
            return resultPath;
        }
    }
}
