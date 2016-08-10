using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TrafficWebScrape.Traffic
{
    class Traffic
    {
        private ArrayList events = new ArrayList();
        private string trafficURL = "";

        public Traffic()
        {
            TrafficURL = "http://api.hatrafficinfo.dft.gov.uk/datexphase2/dtxRss.aspx?srcUrl=http://hatrafficinfo.dft.gov.uk/feeds/rss/UnplannedEvents.xml&justToday=Y&sortfield=road&sortorder=up";
        }

        public Traffic(string trafficURL)
        {
            TrafficURL = trafficURL;
        }

        public Traffic(ArrayList events)
        {
            Events = events;
        }

        public void Process()
        {
            try
            {
                foreach (SyndicationItem item in GetRSSFeed().Items)
                {
                    Event newEvent = new Event(item.Title.Text, item.Summary.Text);
                    newEvent.Process();
                    Events.Add(newEvent);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
            byte[] bytes = System.Text.UTF8Encoding.ASCII.GetBytes(xml);
            XmlReader reader = XmlReader.Create(new MemoryStream(bytes));
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            return feed;
        }

        public ArrayList Events
        {
            get
            {
                return events;
            }

            set
            {
                if (value == null)
                {
                    value = new ArrayList();
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
    }
}
