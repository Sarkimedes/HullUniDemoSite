using System;
using System.Linq;
using HullUniDemoSite.Controllers;
using HullUniDemoSite.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HullUniDemoSite.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void ScoresController_NumberOfScoresIncreasesBy1_WhenAScoreIsAddedToTheDB()
        {
            var controller = new ScoresController();
            var oldScoreCount = controller.GetScores().Count();

            var result = controller.PostScore(new Score() {PlayerName = "Fred", Moves = 5});

            var newScoreCount = controller.GetScores().Count();
            Assert.AreEqual(oldScoreCount + 1, newScoreCount);
        }
    }
}
