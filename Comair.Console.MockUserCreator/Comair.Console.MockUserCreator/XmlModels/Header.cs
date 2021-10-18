using System.Xml.Serialization;

namespace Comair.Console.MockUserCreator.XmlModels
{
    /* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
    [XmlRoot(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
		public class Header
		{
			[XmlAttribute(AttributeName = "s", Namespace = "http://www.w3.org/2000/xmlns/")]
			public string S { get; set; }
		}

	}
