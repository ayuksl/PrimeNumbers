using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Galgenraten
{

    public class LogData 
    {

        private readonly List<LogDataItem> Items;
        public string Path { get; private set; }


        public LogData(string path)
        {
            this.Items = new List<LogDataItem>();
            this.Path = path;
        }

        public void AddLog(LogDataItem item)
        {
            Items.Add(item);
        }

        public void Save()
        {
            if (!File.Exists(this.Path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(this.Path))
                {
                    foreach (LogDataItem item in Items)
                    {
                        sw.WriteLine(item.ToCsv());
                    }
                }
            }

            // Open the file to read from.
            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s;
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(s);

            //    }

            //}

        //            if (File.Exists("Log.xml") is not true)
        //    {
                
        //        file xml_doc = new XmlDocument();
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

        }

        public void Read()
        {

        }

        public void PrintItems()
        {
            foreach (LogDataItem item in this.Items)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }

}
