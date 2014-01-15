using System;
using System.Xml;

namespace xmlTesting
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //XmlWriterSettings settings = new XmlWriterSettings();
        //    //settings.Indent = true;
        //    //// entry value, highest value, lowest, and end value
        //    //XmlWriter writer = XmlWriter.Create("Trades.xml", settings);
        //    //writer.WriteStartDocument();
        //    //int x = 0;
        //    //writer.WriteStartElement("trades");
        //    //while (x < 10)
        //    //{
        //    //    writer.WriteStartElement("trade");
        //    //    writer.WriteAttributeString("date", "1/2/3");
        //    //    writer.WriteAttributeString("time", "11");
        //    //    writer.WriteAttributeString("start", "1");
        //    //    writer.WriteAttributeString("end", "2");
        //    //    writer.WriteAttributeString("high", "3");
        //    //    writer.WriteAttributeString("low", "1");
        //    //    writer.WriteEndElement();
        //    //    x++;
        //    //}
        //    //writer.WriteEndElement();
        //    //writer.WriteEndDocument();

        //    //writer.Flush();
        //    //writer.Close();
        //    //addElement();
        //    //deleteElement(7);
        //    CountElement();
        //    //editElement(4, "2/3/4");

        //    ReadAllElements();
        //}

        public static void CountElement()
        {
            XmlDocument readDoc = new XmlDocument();
            readDoc.Load("Trades.xml");
            XmlNode root = readDoc.DocumentElement;
            int count = readDoc.SelectNodes("descendant::trade").Count;
            Console.WriteLine(count);
            Console.ReadLine();

        }
        public static void DeleteElement(int index)
        {
            XmlDocument doc = new XmlDocument();
 
            doc.Load("Trades.xml");
            XmlNode root = doc.DocumentElement;
            XmlNode node = root.SelectNodes("trade").Item(index);
            root.RemoveChild(node);
            doc.Save("Trades.xml");
        }
        public static void AddElement()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Trades.xml");
            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "trade", null);

            XmlAttribute att = doc.CreateAttribute("date");
            att.Value = "4/22/11";
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("time");
            att.Value = "33";
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("start");
            att.Value = "3";
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("end");
            att.Value = "4";
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("high");
            att.Value = "4";
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("low");
            att.Value = "1";
            newNode.Attributes.Append(att);

            XmlNode root = doc.DocumentElement;
            root.AppendChild(newNode);
            doc.Save("Trades.xml");
        }
        public static void EditElement(int index,string newValue)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("Trades.xml");
            XmlNode root = xmlDoc.DocumentElement;
            XmlNode myNode = root.SelectNodes("trade").Item(index);
            myNode.Attributes[0].Value = newValue;
            xmlDoc.Save("Trades.xml");
        }
        public static void ReadAllElements()
        {
            XmlReader reader = XmlReader.Create("Trades.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "trade")
                {
                    Console.WriteLine("date = " + reader.GetAttribute(0));
                    Console.WriteLine("time = " + reader.GetAttribute(1));
                    Console.WriteLine("start = " + reader.GetAttribute(2));
                    Console.WriteLine("end = " + reader.GetAttribute(3));
                    Console.WriteLine("high = " + reader.GetAttribute(4));
                    Console.WriteLine("low = " + reader.GetAttribute(5));
                }
            }
            Console.ReadLine();
        }
    }
}
