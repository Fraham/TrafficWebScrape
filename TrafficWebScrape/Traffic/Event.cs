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

        private int delayedMinutes;

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
            //Console.WriteLine(Summary);
            Status = ProcessRegex(@"Status : (.*)").Trim();
            Location = ProcessRegex(@"Location : The (.*)").Trim();
            TimeToClear = ProcessRegex(@"Time To Clear : (.*)").Trim();
            ReturnToNormal = ProcessRegex(@"Return To Normal : (.*)").Trim();
            LanesClosed = ProcessRegex(@"Lanes Closed : (.*)").Trim();
            Reason = ProcessRegex(@"Reason : (.*)").Trim();
            Delay = ProcessRegex(@"Delay : (.*)").Trim();
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
            Regex regex = new Regex(regexString);
            Match match = regex.Match(Summary);

            return match.Groups[1].Success ? match.Groups[1].Value : "";
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

                Road = ProcessRegex(@"\b[MAa-z0-9]+\b", Location);
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

                StartClear = ProcessRegex(@"([0-9]+:[0-9]+)", TimeToClear, 0);
                EndClear = ProcessRegex(@"([0-9]+:[0-9]+)", TimeToClear, 1);
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

                StartNormal = ProcessRegex(@"([0-9]+:[0-9]+)", ReturnToNormal, 0);
                EndNormal = ProcessRegex(@"([0-9]+:[0-9]+)", ReturnToNormal, 1);
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
                if (value == null || value.Equals(""))
                {
                    value = "Unknown";
                }
                delay = value;

                if (!Delay.Equals("Unknown"))
                {
                    Regex regex = new Regex(@"(([0-9]+) minutes)|(([0-9]+)( and |)(three quarters|a half|a quarter|) hours)");
                    Match match = regex.Match(Delay);

                    if (match.Success)
                    {
                        if (match.Groups[1].Success)
                        {
                            try
                            {
                                DelayedMinutes = Int32.Parse(match.Groups[2].Value);
                            }
                            catch (FormatException fe)
                            {
                                DelayedMinutes = 0;
                            }
                        }
                        else if (match.Groups[3].Success)
                        {
                            int minutes = 0;

                            try
                            {
                                minutes = Int32.Parse(match.Groups[4].Value) * 60;
                            }
                            catch (FormatException fe)
                            {
                                minutes = 0;
                            }

                            if (match.Groups[6].Value.Equals("three quarters"))
                            {
                                minutes += 45;
                            }
                            else if (match.Groups[6].Value.Equals("a half"))
                            {
                                minutes += 30;
                            }
                            else if (match.Groups[6].Value.Equals("a quarter"))
                            {
                                minutes += 15;
                            }

                            DelayedMinutes = minutes;
                        }
                    }
                }
            }
        }

        public int DelayedMinutes
        {
            get
            {
                return delayedMinutes;
            }

            set
            {
                delayedMinutes = value;
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
            row.Cells[12].Value = DelayedMinutes;

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

            if (!Road.Equals(other.Road))
            {
                return false;
            }
            if (!Location.Equals(other.Location))
            {
                return false;
            }
            if (!Status.Equals(other.Status))
            {
                return false;
            }
            if (!TimeToClear.Equals(other.TimeToClear))
            {
                return false;
            }
            if (!StartClear.Equals(other.StartClear))
            {
                return false;
            }
            if (!EndClear.Equals(other.EndClear))
            {
                return false;
            }
            if (!ReturnToNormal.Equals(other.ReturnToNormal))
            {
                return false;
            }
            if (!StartNormal.Equals(other.StartNormal))
            {
                return false;
            }
            if (!EndNormal.Equals(other.EndNormal))
            {
                return false;
            }
            if (!LanesClosed.Equals(other.LanesClosed))
            {
                return false;
            }
            if (!Reason.Equals(other.Reason))
            {
                return false;
            }
            if (!Delay.Equals(other.Delay))
            {
                return false;
            }
            if (DelayedMinutes != other.DelayedMinutes)
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