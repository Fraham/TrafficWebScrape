using System;
using System.Text.RegularExpressions;

namespace TrafficWebScrape.Traffic
{
    class Event
    {
        private string location;
        private string status;
        private string information;

        private string title;
        private string summary;

        public Event(string title, string summary)
        {
            Title = title;
            Summary = summary;
        }

        public Event(string motorway, string status, string information)
        {
            Location = motorway;
            Status = status;
            Information = information;
        }

        public void Process()
        {
            //Console.WriteLine(Title);
            //Console.WriteLine(Summary);

            Status = ProcessRegex(@"(Status.*\n)");
        }

        private string ProcessRegex(string regexString)
        {
            Regex regex = new Regex(regexString);
            Match match = regex.Match(Summary);

            return match.Success ? match.Value : "";
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                if (value == null)
                {
                    value = "Motorway unknown";
                }

                location = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                if (value == null)
                {
                    value = "Status unknown";
                }

                status = value;
            }
        }

        public string Information
        {
            get
            {
                return information;
            }

            set
            {
                if (value == null)
                {
                    value = "No information";
                }

                information = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Summary
        {
            get
            {
                return summary;
            }

            set
            {
                summary = value;
            }
        }
    }
}
