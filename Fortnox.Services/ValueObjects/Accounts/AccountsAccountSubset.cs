namespace Fortnox.Services.ValueObjects.Accounts
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class AccountsAccountSubset
    {
        public bool Active { get; set; }
        public string Description { get; set; }
        public ushort Number { get; set; }
        public ushort SRU { get; set; }
        public byte Year { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url { get; set; }
    }
}
