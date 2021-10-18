using System.Collections.Generic;
using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "UsageDetails", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class UsageDetails
		{
			[XmlElement(ElementName = "UsageItem", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public List<UsageItem> UsageItem { get; set; }
		}

	}
