using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "UsageInformation", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class UsageInformation
		{
			[XmlElement(ElementName = "UsageDetails", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public UsageDetails UsageDetails { get; set; }
		}

	}
