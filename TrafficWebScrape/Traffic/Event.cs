using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrafficWebScrape.Traffic
{
    public class Event
    {
        private string location;
        private string status;
        private string timeToClear;
        private string returnToNormal;
        private string lanesClosed;
        private string reason;
        private string road;
        private string startClear;
        private string endClear;
        private string startNormal;
        private string endNormal;
        private string delay;

        private string title;
        private string summary;

        public Event(string title, string summary)
        {
            Title = title;
            Summary = summary;
        }

        public Event(string location, string status, string timeToClear, string returnToNormal, string lanesClosed, string reason, string road, string startClear, string endClear, string startNormal, string endNormal, string delay)
        {
            Location = location;
            Status = status;
            TimeToClear = timeToClear;
            ReturnToNormal = returnToNormal;
            LanesClosed = lanesClosed;
            Reason = reason;
            Road = road;
            StartClear = startClear;
            EndClear = endClear;
            StartNormal = startNormal;
            EndNormal = endNormal;
            Delay = delay;
        }


        public void Process()
        {
            Console.WriteLine(Summary);
            Status = ProcessRegex(@"(Status.*.)").Replace("Status : ", "").Trim();
            Location = ProcessRegex(@"(Location.*.)").Replace("Location : The ", "").Trim();
            TimeToClear = ProcessRegex(@"(Time To Clear.*.)").Replace("Time To Clear : ", "").Trim();
            ReturnToNormal = ProcessRegex(@"(Return To Normal.*.)").Replace("Return To Normal : ", "").Trim();
            LanesClosed = ProcessRegex(@"(Lanes Closed.*.)").Replace("Lanes Closed : ", "").Trim();
            Reason = ProcessRegex(@"(Reason.*.)").Replace("Reason : ", "").Trim();
            Delay = ProcessRegex(@"(Delay.*.)").Replace("Delay : ", "").Trim();
            Road = ProcessRegex(@"\b[A-Za-z0-9]+\b", Location);
            StartClear = ProcessRegex(@"([0-9]+:[0-9]+)", TimeToClear, 0);
            EndClear = ProcessRegex(@"([0-9]+:[0-9]+)", TimeToClear, 1);
            StartNormal = ProcessRegex(@"([0-9]+:[0-9]+)", ReturnToNormal, 0);
            EndNormal = ProcessRegex(@"([0-9]+:[0-9]+)", ReturnToNormal, 1);
        }

        private string ProcessRegex(string regexString, string matchingWith, int index)
        {
            Regex regex = new Regex(regexString);
            MatchCollection match = regex.Matches(matchingWith);

            if (match.Count <= index)
            {
                return "";
            }

            return match[index].Success ? match[index].Value : "";
        }

        private string ProcessRegex(string regexString, string matchingWith)
        {
            Regex regex = new Regex(regexString);
            Match match = regex.Match(matchingWith);

            return match.Success ? match.Value : "";
        }

        private string ProcessRegex(string regexString)
        {
            return ProcessRegex(regexString, Summary);
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
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
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }

                status = value;
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

        public string TimeToClear
        {
            get
            {
                return timeToClear;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }

                timeToClear = value;
            }
        }

        public string ReturnToNormal
        {
            get
            {
                return returnToNormal;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }

                returnToNormal = value;
            }
        }

        public string LanesClosed
        {
            get
            {
                return lanesClosed;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }

                lanesClosed = value;
            }
        }

        public string Reason
        {
            get
            {
                return reason;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }

                reason = value;
            }
        }

        public new string ToString
        {
            get
            {
                return String.Format("Location: {0}, Status: {1}, Time To Clear: {2}, Return To Normal: {3}, Lanes Closed: {4}, Reason {5}", Location, Status, TimeToClear, ReturnToNormal, LanesClosed, Reason);
            }
        }

        public string Road
        {
            get
            {
                return road;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }
                road = value;
            }
        }

        public string StartClear
        {
            get
            {
                return startClear;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }
                startClear = value;
            }
        }

        public string EndClear
        {
            get
            {
                return endClear;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }
                endClear = value;
            }
        }

        public string StartNormal
        {
            get
            {
                return startNormal;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }
                startNormal = value;
            }
        }

        public string EndNormal
        {
            get
            {
                return endNormal;
            }

            set
            {
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }
                endNormal = value;
            }
        }

        public string Delay
        {
            get
            {
                return delay;
            }

            set
            {
                delay = value;
            }
        }

        public DataGridViewRow GetDataGridViewRow(DataGridView dgv)
        {
            int rowId = dgv.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = dgv.Rows[rowId];

            row.Cells[0].Value = Road;
            row.Cells[1].Value = Location;
            row.Cells[2].Value = Status;
            row.Cells[3].Value = TimeToClear;
            row.Cells[4].Value = StartClear;
            row.Cells[5].Value = EndClear;
            row.Cells[6].Value = ReturnToNormal;
            row.Cells[7].Value = StartNormal;
            row.Cells[8].Value = EndNormal;
            row.Cells[9].Value = LanesClosed;
            row.Cells[10].Value = Reason;
            row.Cells[11].Value = Delay;

            return row;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Event other = obj as Event;

            if (Road.Equals(other.Road))
            {
                return false;
            }
            if (Location.Equals(other.Location))
            {
                return false;
            }
            if (Status.Equals(other.Status))
            {
                return false;
            }
            if (TimeToClear.Equals(other.TimeToClear))
            {
                return false;
            }
            if (StartClear.Equals(other.StartClear))
            {
                return false;
            }
            if (EndClear.Equals(other.EndClear))
            {
                return false;
            }
            if (ReturnToNormal.Equals(other.ReturnToNormal))
            {
                return false;
            }
            if (StartNormal.Equals(other.StartNormal))
            {
                return false;
            }
            if (EndNormal.Equals(other.EndNormal))
            {
                return false;
            }
            if (LanesClosed.Equals(other.LanesClosed))
            {
                return false;
            }
            if (Reason.Equals(other.Reason))
            {
                return false;
            }

            return true;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}