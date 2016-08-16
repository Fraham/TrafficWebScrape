using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using TrafficWebScrape.Highway;

namespace TrafficWebScrape.Traffic
{
    public class Traffic
    {
        private List<Event> events = new List<Event>();
        private string trafficURL = "";

        public Traffic()
        {
            TrafficURL = "http://api.hatrafficinfo.dft.gov.uk/datexphase2/dtxRss.aspx?srcUrl=http://hatrafficinfo.dft.gov.uk/feeds/rss/UnplannedEvents.xml&justToday=Y&sortfield=road&sortorder=up";
        }

        public Traffic(string trafficURL)
        {
            TrafficURL = trafficURL;
        }

        public Traffic(List<Event> events)
        {
            Events = events;
        }

        public void Process(string xml)
        {
            XmlReader reader = XmlReader.Create(xml);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            foreach (SyndicationItem item in feed.Items)
            {
                try
                {
                    Event newEvent = new Event(item.Title.Text, item.Summary.Text);
                    newEvent.Process();
                    Events.Add(newEvent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void Process()
        {
            foreach (SyndicationItem item in GetRSSFeed().Items)
            {
                try
                {
                    Event newEvent = new Event(item.Title.Text, item.Summary.Text);
                    newEvent.Process();
                    Events.Add(newEvent);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public SyndicationFeed GetRSSFeed()
        {
            string xml;
            using (WebClient webClient = new WebClient())
            {
                xml = Encoding.UTF8.GetString(webClient.DownloadData(TrafficURL));
            }
            xml = xml.Replace("BST", "GMT");
            byte[] bytes = Encoding.ASCII.GetBytes(xml);
            XmlReader reader = XmlReader.Create(new MemoryStream(bytes));
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            return feed;
        }

        public List<Event> Events
        {
            get
            {
                return events;
            }

            set
            {
                if (value == null)
                {
                    value = new List<Event>();
                }

                events = value;
            }
        }

        public string TrafficURL
        {
            get
            {
                return trafficURL;
            }

            set
            {
                trafficURL = value;
            }
        }

        public new string ToString
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                foreach (Event e in events)
                {
                    sb.Append(e.ToString);
                    sb.Append(System.Environment.NewLine);
                }

                return sb.ToString();
            }
        }

        public List<DataGridViewRow> GetDataGridViewRows(DataGridView dgv)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            foreach (Event e in Events)
            {
                rows.Add(e.GetDataGridViewRow(dgv));
            }

            return rows;
        }

        public List<DataGridViewRow> GetDataGridViewRows(DataGridView dgv, Road road)
        {
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            List<Event> filteredList = Events.Where(x => x.Road.Equals(road)).ToList();

            foreach (Event e in filteredList)
            {
                rows.Add(e.GetDataGridViewRow(dgv));
            }

            return rows;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Traffic other = obj as Traffic;

            if (Events.Equals(other.Events))
            {
                return false;
            }

            return true;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return base.GetHashCode();
        }
    }
}