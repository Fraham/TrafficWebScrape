using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficWebScrape.Highway;
using System.Linq;
using System.IO;

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

            road.Name = "Testing";
            Assert.AreEqual("Testing", road.Name);
        }

        [TestMethod]
        public void RoadARoad()
        {
            Assert.AreEqual("A570", aRoad.Name);
            Assert.AreEqual("A570", aRoad.ToString);

            Assert.AreEqual(Road.GetRoad("A570"), aRoad);

            aRoad.Name = "Testing";
            Assert.AreEqual("Testing", aRoad.Name);
        }

        [TestMethod]
        public void RoadMotorway()
        {
            Assert.AreEqual("M6", motorway.Name);
            Assert.AreEqual("M6", motorway.ToString);

            Assert.AreEqual(Road.GetRoad("M6"), motorway);

            motorway.Name = "Testing";
            Assert.AreEqual("Testing", motorway.Name);
        }

        [TestMethod]
        public void RoadLoadSave()
        {
            File.Delete("roads.xml");

            Road.Roads = new List<Road>();

            Road.Roads.Add(road);
            Road.Roads.Add(aRoad);
            Road.Roads.Add(motorway);

            Road.Save();

            Road.Roads = new List<Road>();

            Road.Load();

            Assert.AreEqual(3, Road.Roads.Count);
        }
    }
}
