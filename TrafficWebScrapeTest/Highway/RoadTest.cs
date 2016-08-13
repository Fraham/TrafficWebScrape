using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficWebScrape.Highway;

namespace TrafficWebScrapeTest.Highway
{
    /// <summary>
    /// Summary description for RoadTest
    /// </summary>
    [TestClass]
    public class RoadTest
    {
        private Road road;
        private Road aRoad;
        private Road motorway;

        [TestInitialize()]
        public void Initialize()
        {
            road = new Road("Test");
            aRoad = new ARoad("A570");
            motorway = new Motorway("M6");
        }

        [TestMethod]
        public void RoadRoad()
        {
            Assert.AreEqual("Test", road.Name);
            Assert.AreEqual("Test", road.ToString);

            Assert.AreEqual(Road.GetRoad("Test"), road);
        }

        [TestMethod]
        public void RoadARoad()
        {
            Assert.AreEqual("A570", aRoad.Name);
            Assert.AreEqual("A570", aRoad.ToString);

            Assert.AreEqual(Road.GetRoad("A570"), aRoad);
        }

        [TestMethod]
        public void RoadMotorway()
        {
            Assert.AreEqual("M6", motorway.Name);
            Assert.AreEqual("M6", motorway.ToString);

            Assert.AreEqual(Road.GetRoad("M6"), motorway);
        }
    }
}
