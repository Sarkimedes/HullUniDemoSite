using System;
using System.Linq;
using System.Web.Mvc;
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

        [TestMethod]
        public void HomeController_ViewBagScoresMatchesScoreCount_AfterScoreIsAddedToDB()
        {
            var scoresController = new ScoresController();
            scoresController.PostScore(new Score() { PlayerName = "Jim", Moves = 8 });
            var scoreCount = scoresController.GetScores().Count();
            var homeController=  new HomeController();
            var viewBagScores = homeController.Index() as ViewResult;
            Assert.AreEqual(viewBagScores.ViewBag.Scores.Count, scoreCount);

        }
    }
}
