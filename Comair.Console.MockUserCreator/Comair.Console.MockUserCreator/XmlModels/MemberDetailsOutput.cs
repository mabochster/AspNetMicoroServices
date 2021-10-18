using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "MemberDetailsOutput", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class MemberDetailsOutput
		{
			[XmlElement(ElementName = "MemberDetails", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public MemberDetails MemberDetails { get; set; }
		}

	}
