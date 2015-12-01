using System;
using HullUniDemoSite.Controllers;
using HullUniDemoSite.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HullUniDemoSite.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var controller = new ScoresController();
            var result = controller.PostScore(new Score() {PlayerName = "Fred", Moves = 5});
        }
    }
}
