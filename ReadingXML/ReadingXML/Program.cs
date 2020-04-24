using System;
using System.Xml;
using System.Text;

namespace ReadingXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader xmlReader = XmlReader.Create("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                {
                    if (xmlReader.HasAttributes)
                    
                        Console.WriteLine(xmlReader.GetAttribute("currency")+ " : " + xmlReader.GetAttribute("rate"));  
                    
                }
            }
            XmlDocument xDOc = new XmlDocument();
            xDOc.Load("https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            foreach(XmlNode xnode in xDOc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
            {
                Console.WriteLine(xnode.Attributes["currency"].Value + " " + xnode.Attributes["rate"].Value);
              
            }
            Console.WriteLine(xDOc.DocumentElement.InnerText);
            Console.WriteLine(xDOc.DocumentElement.Name);


            XmlDocument xdos = new XmlDocument(); 
            xdos.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNode titleNode = xdos.SelectSingleNode("//rss/channel/title");
            if (titleNode != null)
                Console.WriteLine(titleNode.InnerText);

            XmlNodeList itemNodes = xdos.SelectNodes("//rss/channel/item");
            foreach(XmlNode itemnode in itemNodes)
            {
                XmlNode titlenode = itemnode.SelectSingleNode("title");
                XmlNode date= itemnode.SelectSingleNode("pubDate");

                if ((titleNode != null) && (date != null))
                    Console.WriteLine(titleNode.InnerText + date.InnerText); 

            }


            //Writing XML with Xml Writer class


            //XmlWriter xmlwriter = XmlWriter.Create("C:\\Users\\Bizruntime-50\\Desktop\\test.xml");
            //xmlwriter.WriteStartDocument();
            //xmlwriter.WriteStartElement("users");
            //xmlwriter.WriteStartElement("user");
            //xmlwriter.WriteAttributeString("Age", "45");
            //xmlwriter.WriteString("Aditya");
            //xmlwriter.WriteEndElement();

            //xmlwriter.WriteStartElement("user");
            //xmlwriter.WriteAttributeString("Age", "45");
            //xmlwriter.WriteString("Sharma");
            //xmlwriter.WriteEndDocument();
            //xmlwriter.Close();

            //Writing XML with the XmlDocument class

            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("users");
            xmlDoc.AppendChild(rootNode);

            XmlNode userNode = xmlDoc.CreateElement("user");
            XmlAttribute attribute = xmlDoc.CreateAttribute("age");
            attribute.Value = "42";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = "John Doe";
            rootNode.AppendChild(userNode);

            xmlDoc.Save("C:\\Users\\Bizruntime-50\\Desktop\\test-doc.xml");

            Console.ReadLine();
        
        }




    }
}
