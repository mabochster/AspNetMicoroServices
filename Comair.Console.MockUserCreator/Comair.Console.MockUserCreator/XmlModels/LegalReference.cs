using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "LegalReference", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class LegalReference
		{
			[XmlElement(ElementName = "LegalReferenceNumber", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string LegalReferenceNumber { get; set; }
			[XmlElement(ElementName = "LegalReferenceType", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string LegalReferenceType { get; set; }
		}

	}
