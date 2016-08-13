using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficWebScrape.Highway;
using TrafficWebScrape.Traffic;

namespace TrafficWebScrape.Tests
{
    [TestClass]
    public class EventTests
    {
        private Event event1;
        private Event event2;
        private Event event3;

        private string event2location = "M62 eastbound between junctions J3  and J4 .";
        private string event2status = "Currently Active.";
        private string event2timeToClear = "Unknown";
        private string event2returnToNormal = "Normal traffic conditions are expected between 17:00 and 17:15 on 11 August 2016.";
        private string event2lanesClosed = "Unknown";
        private string event2reason = "Congestion.";
        private Road event2road = Road.GetRoad("M62");
        private string event2startClear = "Unknown";
        private string event2endClear = "Unknown";
        private string event2startNormal = "17:00";
        private string event2endNormal = "17:15";
        private string event2delay = "There are currently delays of 10 minutes against expected traffic.";
        private int event2delayedMinutes = 10;
        private string event2direction = "eastbound";
        private string event2areaAffected = "between junctions J3  and J4";

        [TestInitialize()]
        public void Initialize()
        {
            event1 = new Event("", "Location : The M67 eastbound between junctions J3  and J4 .\n Status : Currently Active. \n Return To Normal : Normal traffic conditions are expected between 17:00 and 17:15 on 11 August 2016. \n Delay : There are currently delays of 10 minutes against expected traffic. \n Reason : Congestion. \n");
            event1.Process();
            event2 = new Event(event2location, event2status, event2timeToClear, event2returnToNormal, event2lanesClosed, event2reason, event2road, event2startClear, event2endClear, event2startNormal, event2endNormal, event2delay, event2delayedMinutes, event2direction, event2areaAffected);
            event3 = new Event(event2location, event2status, event2timeToClear, event2returnToNormal, event2lanesClosed, event2reason, event2delay);
        }

        [TestMethod]
        public void EventLocation()
        {
            Assert.AreEqual(event2location, event2.Location);
            Assert.AreEqual("M67 eastbound between junctions J3  and J4 .", event1.Location);

            event3.Location = null;
            Assert.AreEqual("Unknown", event3.Location);
        }

        [TestMethod]
        public void EventStatus()
        {
            Assert.AreEqual(event2status, event2.Status);
            Assert.AreEqual("Currently Active.", event1.Status);

            event3.Status = null;
            Assert.AreEqual("Unknown", event3.Status);
        }

        [TestMethod]
        public void EventTimeToClear()
        {
            Assert.AreEqual(event2timeToClear, event2.TimeToClear);
            Assert.AreEqual("Unknown", event1.TimeToClear);

            event3.TimeToClear = null;
            Assert.AreEqual("Unknown", event3.TimeToClear);
        }

        [TestMethod]
        public void EventReturnToNormal()
        {
            Assert.AreEqual(event2returnToNormal, event2.ReturnToNormal);
            Assert.AreEqual("Normal traffic conditions are expected between 17:00 and 17:15 on 11 August 2016.", event1.ReturnToNormal);

            event3.ReturnToNormal = null;
            Assert.AreEqual("Unknown", event3.ReturnToNormal);
        }

        [TestMethod]
        public void EventLanesClosed()
        {
            Assert.AreEqual(event2lanesClosed, event2.LanesClosed);
            Assert.AreEqual("Unknown", event1.LanesClosed);

            event3.LanesClosed = null;
            Assert.AreEqual("Unknown", event3.LanesClosed);
        }

        [TestMethod]
        public void EventReason()
        {
            Assert.AreEqual(event2reason, event2.Reason);
            Assert.AreEqual("Congestion.", event1.Reason);

            event3.Reason = null;
            Assert.AreEqual("Unknown", event3.Reason);
        }

        [TestMethod]
        public void EventRoad()
        {
            Assert.AreEqual(event2road, event2.Road);
            Assert.AreEqual(Road.GetRoad("M67"), event1.Road);

            event3.Road = null;
            Assert.AreEqual(Road.GetRoad("Unknown"), event3.Road);
        }

        [TestMethod]
        public void EventStartClear()
        {
            Assert.AreEqual(event2startClear, event2.StartClear);
            Assert.AreEqual("Unknown", event1.StartClear);

            event3.StartClear = null;
            Assert.AreEqual("Unknown", event3.StartClear);

            event3.TimeToClear = "The event is expected to clear between 04:00 and 04:15 on 12 August 2016.";
            Assert.AreEqual("04:00", event3.StartClear);

            event3.TimeToClear = "The event is expected to clear between 00:15 and 00:30 on 12 August 2016.";
            Assert.AreEqual("00:15", event3.StartClear);

            event3.TimeToClear = "The event is expected to clear between 00:30 and 00:45 on 12 August 2016.";
            Assert.AreEqual("00:30", event3.StartClear);
        }

        [TestMethod]
        public void EventEndClear()
        {
            Assert.AreEqual(event2endClear, event2.EndClear);
            Assert.AreEqual("Unknown", event1.EndClear);

            event3.EndClear = null;
            Assert.AreEqual("Unknown", event3.EndClear);

            event3.TimeToClear = "The event is expected to clear between 04:00 and 04:15 on 12 August 2016.";
            Assert.AreEqual("04:15", event3.EndClear);

            event3.TimeToClear = "The event is expected to clear between 00:15 and 00:30 on 12 August 2016.";
            Assert.AreEqual("00:30", event3.EndClear);

            event3.TimeToClear = "The event is expected to clear between 00:30 and 00:45 on 12 August 2016.";
            Assert.AreEqual("00:45", event3.EndClear);
        }

        [TestMethod]
        public void EventStartNormal()
        {
            Assert.AreEqual(event2startNormal, event2.StartNormal);
            Assert.AreEqual("17:00", event1.StartNormal);

            event3.StartNormal = null;
            Assert.AreEqual("Unknown", event3.StartNormal);

            event3.ReturnToNormal = "Normal traffic conditions are expected between 14:00 and 14:15 on 11 August 2016.";
            Assert.AreEqual("14:00", event3.StartNormal);

            event3.ReturnToNormal = "Normal traffic conditions are expected between 00:00 and 00:15 on 11 August 2016.";
            Assert.AreEqual("00:00", event3.StartNormal);

            event3.ReturnToNormal = "Normal traffic conditions are expected between 00:30 and 00:45 on 11 August 2016.";
            Assert.AreEqual("00:30", event3.StartNormal);
        }

        [TestMethod]
        public void EventEndNormal()
        {
            Assert.AreEqual(event2endNormal, event2.EndNormal);
            Assert.AreEqual("17:15", event1.EndNormal);

            event3.EndNormal = null;
            Assert.AreEqual("Unknown", event3.EndNormal);

            event3.ReturnToNormal = "Normal traffic conditions are expected between 14:00 and 14:15 on 11 August 2016.";
            Assert.AreEqual("14:15", event3.EndNormal);

            event3.ReturnToNormal = "Normal traffic conditions are expected between 00:00 and 00:15 on 11 August 2016.";
            Assert.AreEqual("00:15", event3.EndNormal);

            event3.ReturnToNormal = "Normal traffic conditions are expected between 00:30 and 00:45 on 11 August 2016.";
            Assert.AreEqual("00:45", event3.EndNormal);
        }

        [TestMethod]
        public void EventDelay()
        {
            Assert.AreEqual(event2delay, event2.Delay);
            Assert.AreEqual("There are currently delays of 10 minutes against expected traffic.", event1.Delay);

            event3.Delay = null;
            Assert.AreEqual("Unknown", event3.Delay);
        }

        [TestMethod]
        public void EventDelayedMinutes()
        {
            Assert.AreEqual(event2delayedMinutes, event2.DelayedMinutes);
            Assert.AreEqual(10, event1.DelayedMinutes);

            event3.Delay = "There are currently delays of 30 minutes against expected traffic.";
            Assert.AreEqual(30, event3.DelayedMinutes);

            event3.Delay = "There are currently delays of 1 and a half hours against expected traffic.";
            Assert.AreEqual(90, event3.DelayedMinutes);

            event3.Delay = "There are currently delays of 1 hours against expected traffic.";
            Assert.AreEqual(60, event3.DelayedMinutes);

            event3.Delay = "There are currently delays of 2 hours against expected traffic.";
            Assert.AreEqual(120, event3.DelayedMinutes);

            event3.Delay = "There are currently delays of 10 hours against expected traffic.";
            Assert.AreEqual(600, event3.DelayedMinutes);

            event3.Delay = "There are currently delays of 100 hours against expected traffic.";
            Assert.AreEqual(6000, event3.DelayedMinutes);
        }

        [TestMethod]
        public void EventAreaEffected()
        {
            Assert.AreEqual(event2areaAffected, event2.AreaEffected);
            Assert.AreEqual("between junctions J3  and J4", event1.AreaEffected);

            event3.AreaEffected = null;
            Assert.AreEqual("Unknown", event3.AreaEffected);
        }

        [TestMethod]
        public void EventEquals()
        {
            Assert.AreEqual(event2, event3);
            event3.Location = null;

            Assert.AreNotEqual(event2, event3);
        }
    }
}