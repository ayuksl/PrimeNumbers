//using System;
//using System.IO;
//using System.Xml;
//using System.Xml.Linq;


//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////namespace Galgenraten
//private void SaveGameResults_TO_XML() // Create multi enter points
//{
//    string date = DateTime.Now.ToString();



//    if (File.Exists("Log.xml") is not true)
//    {
//        XmlDocument xml_doc = new XmlDocument();
//        string xml_data = "<statistik>" +
//        "<spiel>" +
//        "<zeitpunkt> " + date + "</zeitpunkt>" +
//        "<anzahlVersuche> " + this.total_trials.ToString() + "</anzahlVersuche>" +
//        "<loesungswort>" + this.random_word + "</loesungswort>" +
//        "<erfolgreich>" + this.Result_status + "</erfolgreich>" +
//        "</spiel>" +
//        "</statistik> ";
//        xml_doc.LoadXml(xml_data);
//        xml_doc.Save("Log.Xml");



//    }
//    else
//    {
//        XDocument xdoc = XDocument.Load("Log.xml");
//        XElement root = xdoc.Element("statistik");
//        IEnumerable<XElement> rows = root.Descendants("spiel");
//        XElement firstRow = rows.First();
//        firstRow.AddBeforeSelf(
//        new XElement("spiel",
//        new XElement("zeitpunkt", date),
//        new XElement("anzahlVersuche", this.total_trials.ToString()),
//        new XElement("loesungswort", this.random_word),
//        new XElement("erfolgreich", this.Result_status)));
//        xdoc.Save("Log.xml");
//    }
//}