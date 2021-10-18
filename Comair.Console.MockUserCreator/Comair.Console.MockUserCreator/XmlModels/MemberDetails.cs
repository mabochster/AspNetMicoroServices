using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "MemberDetails", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class MemberDetails
		{
			[XmlElement(ElementName = "Members", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public Members Members { get; set; }
		}

	}
