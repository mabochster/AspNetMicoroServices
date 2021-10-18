using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "Discount", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class Discount
		{
			[XmlElement(ElementName = "Percentage", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string Percentage { get; set; }
		}

	}
