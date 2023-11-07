using System.Collections.Generic;
using System.Xml.Serialization;

namespace LoanManagement.CoreLogicModels.IndividualRequest2
{

    [XmlRoot(ElementName = "CREDIT_RESPONSE")]
    public class CREDIT_RESPONSE
    {
        [XmlElement(ElementName = "CREDIT_BUREAU")]
        public CreditBureau CREDIT_BUREAU { get; set; }
        [XmlElement(ElementName = "CREDIT_REPORT_PRICE")]
        public List<CreditReportPrice> CREDIT_REPORT_PRICE { get; set; }
        [XmlElement(ElementName = "CREDIT_REPOSITORY_INCLUDED")]
        public CreditRepositoryIncluded CREDIT_REPOSITORY_INCLUDED { get; set; }
        [XmlElement(ElementName = "REQUESTING_PARTY")]
        public RequestingParty REQUESTING_PARTY { get; set; }
        [XmlElement(ElementName = "CREDIT_REQUEST_DATA")]
        public CreditRequestData CREDIT_REQUEST_DATA { get; set; }
        [XmlElement(ElementName = "BORROWER")]
        public Borrower BORROWER { get; set; }
        [XmlElement(ElementName = "CREDIT_LIABILITY")]
        public List<CREDIT_LIABILITY> CREDIT_LIABILITY { get; set; }
        [XmlElement(ElementName = "CREDIT_PUBLIC_RECORD")]
        public List<CreditPublicRecord> CREDIT_PUBLIC_RECORD { get; set; }
        [XmlElement(ElementName = "CREDIT_INQUIRY")]
        public List<CreditInquiry> CREDIT_INQUIRY { get; set; }
        [XmlElement(ElementName = "CREDIT_FILE")]
        public List<CREDIT_FILE> CREDIT_FILE { get; set; }
        [XmlElement(ElementName = "CREDIT_SCORE")]
        public List<CreditScore> CREDIT_SCORE { get; set; }
        [XmlElement(ElementName = "CREDIT_CONSUMER_REFERRAL")]
        public List<CreditConsumerReferral> CREDIT_CONSUMER_REFERRAL { get; set; }
        [XmlElement(ElementName = "CREDIT_SUMMARY")]
        public CreditSummary CREDIT_SUMMARY { get; set; }
        [XmlElement(ElementName = "EMBEDDED_FILE")]
        public List<EmbeddedFile> EMBEDDED_FILE { get; set; }
        [XmlAttribute(AttributeName = "MISMOVersionID")]
        public string MISMOVersionID { get; set; }
        [XmlAttribute(AttributeName = "CreditReportMergeType")]
        public string CreditReportMergeType { get; set; }
        [XmlAttribute(AttributeName = "CreditRatingCodeType")]
        public string CreditRatingCodeType { get; set; }
        [XmlAttribute(AttributeName = "CreditRatingCodeTypeOtherDescription")]
        public string CreditRatingCodeTypeOtherDescription { get; set; }
        [XmlAttribute(AttributeName = "CreditResponseID")]
        public string CreditResponseID { get; set; }
        [XmlAttribute(AttributeName = "CreditReportType")]
        public string CreditReportType { get; set; }
        [XmlAttribute(AttributeName = "CreditReportIdentifier")]
        public string CreditReportIdentifier { get; set; }
        [XmlAttribute(AttributeName = "CreditReportTransactionIdentifier")]
        public string CreditReportTransactionIdentifier { get; set; }
        [XmlAttribute(AttributeName = "CreditReportFirstIssuedDate")]
        public string CreditReportFirstIssuedDate { get; set; }
        [XmlAttribute(AttributeName = "CreditReportLastUpdatedDate")]
        public string CreditReportLastUpdatedDate { get; set; }
    }
}
