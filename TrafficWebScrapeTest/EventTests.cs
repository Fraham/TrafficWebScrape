﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficWebScrape.Traffic;

namespace TrafficWebScrape.Tests
{
    [TestClass]
    public class EventTests
    {
        private Event event1;
        private Event event2;

        private string event2location = "M62 eastbound between junctions J3  and J4 .";
        private string event2status = "Currently Active.";
        private string event2timeToClear = "Unknown";
        private string event2returnToNormal = "Normal traffic conditions are expected between 17:00 and 17:15 on 11 August 2016.";
        private string event2lanesClosed = "Unknown";
        private string event2reason = "Congestion.";
        private string event2road = "M62";
        private string event2startClear = "Unknown";
        private string event2endClear = "Unknown";
        private string event2startNormal = "17:00";
        private string event2endNormal = "17:15";
        private string event2delay = "There are currently delays of 10 minutes against expected traffic.";

        [TestInitialize()]
        public void Initialize()
        {
            event1 = new Event("", "Location : The M67 eastbound between junctions J3  and J4 .\n Status : Currently Active. \n Return To Normal : Normal traffic conditions are expected between 17:00 and 17:15 on 11 August 2016. \n Delay : There are currently delays of 10 minutes against expected traffic. \n Reason : Congestion. \n");
            event1.Process();
            event2 = new Event(event2location, event2status, event2timeToClear, event2returnToNormal, event2lanesClosed, event2reason, event2road, event2startClear, event2endClear, event2startNormal, event2endNormal, event2delay);
        }

        [TestMethod]
        public void EventLocation()
        {
            Assert.AreEqual(event2location, event2.Location);
            Assert.AreEqual("M67 eastbound between junctions J3  and J4 .", event1.Location);
        }

        [TestMethod]
        public void EventStatus()
        {
            Assert.AreEqual(event2status, event2.Status);
            Assert.AreEqual("Currently Active.", event1.Status);
        }

        [TestMethod]
        public void EventTimeToClear()
        {
            Assert.AreEqual(event2timeToClear, event2.TimeToClear);
            Assert.AreEqual("Unknown", event1.TimeToClear);
        }

        [TestMethod]
        public void EventReturnToNormal()
        {
            Assert.AreEqual(event2returnToNormal, event2.ReturnToNormal);
            Assert.AreEqual("Normal traffic conditions are expected between 17:00 and 17:15 on 11 August 2016.", event1.ReturnToNormal);
        }

        [TestMethod]
        public void EventLanesClosed()
        {
            Assert.AreEqual(event2lanesClosed, event2.LanesClosed);
            Assert.AreEqual("Unknown", event1.LanesClosed);
        }

        [TestMethod]
        public void EventReason()
        {
            Assert.AreEqual(event2reason, event2.Reason);
            Assert.AreEqual("Congestion.", event1.Reason);
        }

        [TestMethod]
        public void EventRoad()
        {
            Assert.AreEqual(event2road, event2.Road);
            Assert.AreEqual("M67", event1.Road);
        }

        [TestMethod]
        public void EventStartClear()
        {
            Assert.AreEqual(event2startClear, event2.StartClear);
            Assert.AreEqual("Unknown", event1.StartClear);
        }

        [TestMethod]
        public void EventEndClear()
        {
            Assert.AreEqual(event2endClear, event2.EndClear);
            Assert.AreEqual("Unknown", event1.EndClear);
        }

        [TestMethod]
        public void EventStartNormal()
        {
            Assert.AreEqual(event2startNormal, event2.StartNormal);
            Assert.AreEqual("17:00", event1.StartNormal);
        }

        [TestMethod]
        public void EventEndNormal()
        {
            Assert.AreEqual(event2endNormal, event2.EndNormal);
            Assert.AreEqual("17:15", event1.EndNormal);
        }

        [TestMethod]
        public void EventDelay()
        {
            Assert.AreEqual(event2delay, event2.Delay);
            Assert.AreEqual("There are currently delays of 10 minutes against expected traffic.", event1.Delay);
        }
    }
}