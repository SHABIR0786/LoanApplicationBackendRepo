using System.Xml.Serialization;

namespace LoanManagement.CoreLogicModels.IndividualRequest2
{

    [XmlRoot(ElementName = "REQUESTING_PARTY")]
    public class RequestingParty
    {
        [XmlAttribute(AttributeName = "InternalAccountIdentifier")]
        public string InternalAccountIdentifier { get; set; }
        [XmlAttribute(AttributeName = "LenderCaseIdentifier")]
        public string LenderCaseIdentifier { get; set; }
        [XmlAttribute(AttributeName = "_RequestedByName")]
        public string _RequestedByName { get; set; }
    }
}