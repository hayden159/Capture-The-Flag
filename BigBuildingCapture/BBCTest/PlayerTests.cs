using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BigBuildingCapture;

namespace BBCTest
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void createPlayer()
        {
            Player p1 = new Player(new MainGame());
            p1.playerName = "Stephanie";
            Assert.AreEqual(p1.playerName, "Stephanie", "Player name not working");
        }
    }
}
