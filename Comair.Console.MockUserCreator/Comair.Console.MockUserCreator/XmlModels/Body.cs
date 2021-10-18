using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
		public class Body
		{
			[XmlElement(ElementName = "GetMemberDetailsAndStatusResponseMessage", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public GetMemberDetailsAndStatusResponseMessage GetMemberDetailsAndStatusResponseMessage { get; set; }
		}

	}
