using System.Collections.Generic;
using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "Members", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class Members
		{
			[XmlElement(ElementName = "Member", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public List<Member> Member { get; set; }
		}

	}
