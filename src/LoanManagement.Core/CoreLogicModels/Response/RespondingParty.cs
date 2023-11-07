
using System.Xml.Serialization;

namespace LoanManagement.CoreLogicModels.Response
{
    [XmlRoot(ElementName = "RESPONDING_PARTY")]
    public class RespondingParty
    {
        [XmlElement(ElementName = "CONTACT_DETAIL")]
        public ContactDetail CONTACT_DETAIL { get; set; }
        [XmlAttribute(AttributeName = "_Name")]
        public string _Name { get; set; }
        [XmlAttribute(AttributeName = "_StreetAddress")]
        public string _StreetAddress { get; set; }
        [XmlAttribute(AttributeName = "_StreetAddress2")]
        public string _StreetAddress2 { get; set; }
        [XmlAttribute(AttributeName = "_City")]
        public string _City { get; set; }
        [XmlAttribute(AttributeName = "_State")]
        public string _State { get; set; }
        [XmlAttribute(AttributeName = "_PostalCode")]
        public string _PostalCode { get; set; }
    }
}