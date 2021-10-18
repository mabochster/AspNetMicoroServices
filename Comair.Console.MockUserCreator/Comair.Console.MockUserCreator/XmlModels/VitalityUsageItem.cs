using System.Collections.Generic;
using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "VitalityUsageItem", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class VitalityUsageItem
		{
			[XmlElement(ElementName = "AuthorizationNumber", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string AuthorizationNumber { get; set; }
			[XmlElement(ElementName = "Discounts", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public List<Discounts> Discounts { get; set; }
			[XmlElement(ElementName = "AvailableQuantity", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string AvailableQuantity { get; set; }
			[XmlElement(ElementName = "MaximumQuantity", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string MaximumQuantity { get; set; }
		}

	}
