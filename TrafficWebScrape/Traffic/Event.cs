namespace TrafficWebScrape.Traffic
{
    class Event
    {
        private string motorway;
        private string status;
        private string information;

        public Event(string motorway, string status, string information)
        {
            Motorway = motorway;
            Status = status;
            Information = information;
        }

        public string Motorway
        {
            get
            {
                return motorway;
            }

            set
            {
                if (value == null)
                {
                    value = "Motorway unknown";
                }

                motorway = value;
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
    }
}
