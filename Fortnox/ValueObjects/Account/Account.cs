namespace Fortnox.ValueObjects.Account
{
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public class Account : ResponseBase
    {
        public bool Active { get; set; }
        public byte BalanceBroughtForward { get; set; }
        public byte BalanceCarriedForward { get; set; }
        public object CostCenter { get; set; }
        public string CostCenterSettings { get; set; }
        public string Description { get; set; }
        public ushort Number { get; set; }
        public byte Project { get; set; }
        public string ProjectSettings { get; set; }
        public ushort SRU { get; set; }
        public object TransactionInformation { get; set; }
        public string TransactionInformationSettings { get; set; }
        public object VATCode { get; set; }
        public byte Year { get; set; }
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string url { get; set; }
    }

}




