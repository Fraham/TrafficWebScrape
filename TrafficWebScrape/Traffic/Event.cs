using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TrafficWebScrape.Traffic
{
    class Event
    {
        private string location;
        private string status;
        private string timeToClear;
        private string returnToNormal;
        private string lanesClosed;
        private string reason;

        private string title;
        private string summary;

        public Event(string title, string summary)
        {
            Title = title;
            Summary = summary;
        }

        public Event(string location, string status, string timeToClear, string returnToNormal, string lanesClosed, string reason)
        {
            Location = location;
            Status = status;
            TimeToClear = timeToClear;
            ReturnToNormal = returnToNormal;
            LanesClosed = lanesClosed;
            Reason = reason;
        }

        public void Process()
        {
            Status = ProcessRegex(@"(Status.*.)").Replace("Status : ", "").Trim();
            Location = ProcessRegex(@"(Location.*.)").Replace("Location : ", "").Trim();
            TimeToClear = ProcessRegex(@"(Time To Clear.*.)").Replace("Time To Clear : ", "").Trim();
            ReturnToNormal = ProcessRegex(@"(Return To Normal.*.)").Replace("Return To Normal : ", "").Trim();
            LanesClosed = ProcessRegex(@"(Lanes Closed.*.)").Replace("Lanes Closed : ", "").Trim();
            Reason = ProcessRegex(@"(Reason.*.)").Replace("Reason : ", "").Trim();
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
                if (value == null || value == "")
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
                if (value == null || value == "")
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
                if (value == null || value == "")
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
                if (value == null || value == "")
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
                if (value == null || value == "")
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
                if (value == null || value == "")
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

        public DataGridViewRow GetDataGridViewRow(DataGridView dgv)
        {
            //DataGridViewRow row = (DataGridViewRow)dgv.RowTemplate.Clone();
            int rowId = dgv.Rows.Add();

            // Grab the new row!
            DataGridViewRow row = dgv.Rows[rowId];

            row.Cells[0].Value = Location;
            row.Cells[1].Value = Status;
            row.Cells[2].Value = TimeToClear;
            row.Cells[3].Value = ReturnToNormal;
            row.Cells[4].Value = LanesClosed;
            row.Cells[5].Value = Reason;

            return row;
        }
    }
}
