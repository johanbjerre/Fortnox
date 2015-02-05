using System;
using System.IO;
using Fortnox.Helpers;
using Fortnox.ValueObjects.Article;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NMock;
using SoftHouse.Scraper.Interfaces;

namespace Fortnox.UnitTest
{
    [TestClass]
    public class TestUrl
    {
        private Mock<IHtmlScraper> _htmlScraper;

        [TestInitialize]
        public void TestInit()
        {
            var mockFactory = new MockFactory();
            _htmlScraper = mockFactory.CreateMock<IHtmlScraper>();
        }

        [TestMethod]
        public void TestGetArticleFlow()
        {
            var articleNumber = "1";
            var url = "https://api.fortnox.se/3/articles/" + articleNumber;
            _htmlScraper.Expects.AtLeast(0).GetProperty(d => d.LastContent).WillReturn(Xmls.Article1);
            _htmlScraper.Expects.AtLeast(0)
                        .Method(d => d.PerformRequest(url, null, null, null, null, null))
                        .WithAnyArguments()
                        .WillReturn("");

            var obj = new PrivateType(typeof(CommunicationHelper));
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
