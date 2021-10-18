using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "BankUsageItem", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class BankUsageItem
		{
			[XmlElement(ElementName = "Discounts", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public Discounts Discounts { get; set; }
			[XmlElement(ElementName = "AuthorizationNumber", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string AuthorizationNumber { get; set; }
		}

	}
