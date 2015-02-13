using System.Xml.Serialization;

namespace Fortnox.Services.ValueObjects.Articles
{
    public class NewDataSet
    {
        [XmlElement("Articles")]
        public Services.ValueObjects.Articles.Articles[] Items { get; set; }
    }
}
