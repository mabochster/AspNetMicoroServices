using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    [XmlRoot(ElementName = "Member", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
		public class Member
		{
			[XmlElement(ElementName = "FirstName", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string FirstName { get; set; }
			[XmlElement(ElementName = "LastName", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string LastName { get; set; }
			[XmlElement(ElementName = "PreferredName", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string PreferredName { get; set; }
			[XmlElement(ElementName = "Gender", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string Gender { get; set; }
			[XmlElement(ElementName = "UsageInformation", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public UsageInformation UsageInformation { get; set; }
			[XmlElement(ElementName = "VitalityWelnessStatus", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string VitalityWelnessStatus { get; set; }
			[XmlElement(ElementName = "DateOfBirth", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string DateOfBirth { get; set; }
			[XmlElement(ElementName = "EntityNumber", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string EntityNumber { get; set; }
			[XmlElement(ElementName = "LegalReference", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public LegalReference LegalReference { get; set; }
			[XmlElement(ElementName = "CellphoneNumber", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string CellphoneNumber { get; set; }
			[XmlElement(ElementName = "EmailAddress", Namespace = "http://schemas.discovery.co.za/travel-benefits")]
			public string EmailAddress { get; set; }
		}

	}
