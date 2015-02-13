namespace Fortnox.Services.ValueObjects.Accounts
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Accounts : ResponseBase
    {
        [System.Xml.Serialization.XmlElementAttribute("AccountSubset")]
        public AccountsAccountSubset[] AccountSubset { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort TotalResources { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TotalPages { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte CurrentPage { get; set; }
    }
}







