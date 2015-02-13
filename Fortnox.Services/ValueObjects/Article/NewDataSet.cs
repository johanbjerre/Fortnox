using System.Xml.Serialization;

namespace Fortnox.Services.ValueObjects.Article
{
    public class NewDataSet
    {
        [XmlElement("Article")]
        public Services.ValueObjects.Article.Article[] Items { get; set; }
    }
}
