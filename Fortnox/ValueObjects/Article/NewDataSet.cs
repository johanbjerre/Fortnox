using System.Xml.Serialization;

namespace Fortnox.ValueObjects.Article
{
    public class NewDataSet
    {
        [XmlElementAttribute("Article")]
        public Article[] Items { get; set; }
    }
}
