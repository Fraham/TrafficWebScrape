using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficWebScrape.Problem;
using System.IO;
using System.Collections.Generic;

namespace TrafficWebScrapeTest.Problem
{
    [TestClass]
    public class TrafficProblemTest
    {
        private TrafficProblem problem1;
        private TrafficProblem problem2;

        private string cause = "Congestion.";

        [TestInitialize()]
        public void Initialize()
        {
            problem1 = new TrafficProblem(cause);
            problem2 = TrafficProblem.GetProblem(cause);
        }

        [TestMethod]
        public void TrafficProblemReason()
        {
            Assert.AreEqual(cause, problem1.Reason);

            Assert.AreEqual(problem1.Reason, problem2.Reason);

            problem1.Reason = "Cheese";
            Assert.AreEqual("Cheese", problem1.Reason);

            problem1.Reason = "";
            Assert.AreEqual("Unknown", problem1.Reason);

            problem1.Reason = null;
            Assert.AreEqual("Unknown", problem1.Reason);
        }

        [TestMethod]
        public void TrafficProblemToString()
        {
            Assert.AreEqual(cause, problem1.ToString);

            Assert.AreEqual(problem1.ToString, problem2.ToString);
        }


        [TestMethod]
        public void TrafficProblemEquals()
        {
            Assert.AreEqual(problem2, problem1);

            problem2 = new TrafficProblem("test");

            Assert.AreNotEqual(problem2, problem1);
        }

        [TestMethod]
        public void TrafficProblemLoadSave()
        {
            File.Delete("problems.xml");

            TrafficProblem.Problems = new List<TrafficProblem>();

            TrafficProblem.Problems.Add(problem1);
            TrafficProblem.Problems.Add(problem2);

            TrafficProblem.Save();

            TrafficProblem.Problems = new List<TrafficProblem>();

            TrafficProblem.Load();

            Assert.AreEqual(2, TrafficProblem.Problems.Count);

            Assert.IsTrue(TrafficProblem.Problems.Contains(problem1));
            Assert.IsTrue(TrafficProblem.Problems.Contains(problem2));
        }
    }
}
