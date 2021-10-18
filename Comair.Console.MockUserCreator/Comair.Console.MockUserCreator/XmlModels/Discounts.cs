using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "Discounts", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class Discounts
		{
			[XmlElement(ElementName = "DiscountPercentage", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string DiscountPercentage { get; set; }
			[XmlElement(ElementName = "DiscountType", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string DiscountType { get; set; }
			[XmlElement(ElementName = "ClassIndicator", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string ClassIndicator { get; set; }
			[XmlElement(ElementName = "EligibleProduct", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string EligibleProduct { get; set; }
			[XmlElement(ElementName = "DiscountProductType", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string DiscountProductType { get; set; }
			[XmlElement(ElementName = "Discount", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public Discount Discount { get; set; }
			[XmlElement(ElementName = "AvailableQuantity", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string AvailableQuantity { get; set; }
			[XmlElement(ElementName = "MaximumQuantity", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string MaximumQuantity { get; set; }
			[XmlElement(ElementName = "EligibilityIndicator", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string EligibilityIndicator { get; set; }
		}

	}
