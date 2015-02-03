using System.Xml.Serialization;

namespace Fortnox.ValueObjects.Articles
{
    public class Articles : ResponseBase
    {
        [XmlElement("ArticleSubset", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ArticlesArticleSubset[] ArticleSubset { get; set; }

        [XmlAttribute]
        public string TotalResources { get; set; }

        [XmlAttribute]
        public string TotalPages { get; set; }

        [XmlAttribute]
        public string CurrentPage { get; set; }
    }





}
