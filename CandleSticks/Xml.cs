﻿using System;
using System.Xml;
using System.Collections;
using System.Collections.Generic;

namespace CandleSticks
{
    public class priceData
    {
        public string date { get;  set; }
        public string time { get;  set; }
        public string start { get;  set; }
        public string end { get;  set; }
        public string high { get;  set; }
        public string low { get;  set; }
    }

    public class XmlForCandleSticks
    {
        public void CreateXML(string date,string time,string start,string end,string high,string low)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            // entry value, highest value, lowest, and end value
            XmlWriter writer = XmlWriter.Create("Trades.xml", settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("trades");
            
            writer.WriteStartElement("trade");
            writer.WriteAttributeString("date", date);
            writer.WriteAttributeString("time", time);
            writer.WriteAttributeString("start", start);
            writer.WriteAttributeString("end", end);
            writer.WriteAttributeString("high", high);
            writer.WriteAttributeString("low", low);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument(); 
            writer.Flush();
            writer.Close();
        }

        public int CountElement()
        {
            XmlDocument readDoc = new XmlDocument();
            readDoc.Load("Trades.xml");
            XmlNode root = readDoc.DocumentElement;
            readDoc.Save("Trades.xml");
            int count = readDoc.SelectNodes("descendant::trade").Count;
            return count;

        }
        public void DeleteElement(int index)
        {
            XmlDocument doc = new XmlDocument();
 
            doc.Load("Trades.xml");
            XmlNode root = doc.DocumentElement;
            XmlNode node = root.SelectNodes("trade").Item(index);
            root.RemoveChild(node);
            doc.Save("Trades.xml");
        }
        public void cleanElement()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Trades.xml");
            XmlNode root = doc.DocumentElement;
            int index = CountElement();
            XmlNode node;
            for (int count = 0; count < index; count++) { 
            node = root.SelectNodes("trade").Item(0);
            root.RemoveChild(node);
            }
            doc.Save("Trades.xml");
        }
        public void AddElement(string date, string time, string start, string end, string high, string low)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Trades.xml");
            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "trade", null);

            XmlAttribute att = doc.CreateAttribute("date");
            att.Value = date;
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("time");
            att.Value = time;
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("start");
            att.Value = start;
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("end");
            att.Value = end;
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("high");
            att.Value = high;
            newNode.Attributes.Append(att);
            att = doc.CreateAttribute("low");
            att.Value = low;
            newNode.Attributes.Append(att);

            XmlNode root = doc.DocumentElement;
            root.AppendChild(newNode);
            doc.Save("Trades.xml");
        }
        public void EditElement(int index, string date, string time, string start, string end, string high, string low )
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("Trades.xml");
            XmlNode root = xmlDoc.DocumentElement;
            XmlNode myNode = root.SelectNodes("trade").Item(index);
            myNode.Attributes[0].Value = date;
            myNode.Attributes[1].Value = time;
            myNode.Attributes[2].Value = start;
            myNode.Attributes[3].Value = end;
            myNode.Attributes[4].Value = high;
            myNode.Attributes[5].Value = low;
            xmlDoc.Save("Trades.xml");

        }

        public List<priceData> ReadAllElements()
        {
            List<priceData> pricesList = new List<priceData>();
            

            XmlReader reader = XmlReader.Create("Trades.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "trade")
                {
                    priceData prices = new priceData();
                    prices.date = reader.GetAttribute(0);
                    prices.time = reader.GetAttribute(1);
                    prices.start = reader.GetAttribute(2);
                    prices.end = reader.GetAttribute(3);
                    prices.high = reader.GetAttribute(4);
                    prices.low = reader.GetAttribute(5);
                    pricesList.Add(prices);
                }
                
            }
            reader.Close();
            return pricesList;
        }
    }
}
