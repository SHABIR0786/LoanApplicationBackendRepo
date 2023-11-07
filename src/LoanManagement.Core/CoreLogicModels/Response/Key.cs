
using System.Xml.Serialization;

namespace LoanManagement.CoreLogicModels.Response
{

    [XmlRoot(ElementName = "KEY")]
    public class Key
    {
        [XmlAttribute(AttributeName = "_Name")]
        public string _Name { get; set; }
        [XmlAttribute(AttributeName = "_Value")]
        public string _Value { get; set; }
    }
}