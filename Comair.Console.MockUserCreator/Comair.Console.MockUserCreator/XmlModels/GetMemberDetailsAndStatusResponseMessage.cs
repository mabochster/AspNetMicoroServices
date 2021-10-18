using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "GetMemberDetailsAndStatusResponseMessage", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class GetMemberDetailsAndStatusResponseMessage
		{
			[XmlElement(ElementName = "MemberDetailsOutput", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public MemberDetailsOutput MemberDetailsOutput { get; set; }
			[XmlElement(ElementName = "CorrelationID", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string CorrelationID { get; set; }
			[XmlElement(ElementName = "LoggedInUser", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string LoggedInUser { get; set; }
			[XmlAttribute(AttributeName = "xmlns")]
			public string Xmlns { get; set; }
			[XmlAttribute(AttributeName = "schemaVersion")]
			public string SchemaVersion { get; set; }
		}

	}
