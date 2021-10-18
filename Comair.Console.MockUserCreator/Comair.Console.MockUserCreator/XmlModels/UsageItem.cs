using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "UsageItem", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class UsageItem
		{
			[XmlElement(ElementName = "Mnemonic", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string Mnemonic { get; set; }
			[XmlElement(ElementName = "VitalityUsageItem", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public VitalityUsageItem VitalityUsageItem { get; set; }
			[XmlElement(ElementName = "BankUsageItem", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public BankUsageItem BankUsageItem { get; set; }
		}

	}
