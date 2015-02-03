using System.Xml.Serialization;

namespace Fortnox.ValueObjects.Articles
{
    public class NewDataSet
    {
        [XmlElement("Articles")]
        public Articles[] Items { get; set; }
    }
}
