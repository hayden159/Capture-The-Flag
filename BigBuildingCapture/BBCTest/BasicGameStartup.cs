using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigBuildingCapture;

namespace BBCTest
{
    [TestClass]
    public class BasicGameStartup
    {

        MainGame GameTest = new MainGame();
        
        //Create the Main game
        [TestMethod]
        public void CreateGame()
        {
            GameTest.Name = "BasicStartUp1";
            string[] output = { GameTest.getPointAdjustmentTable().ToString() };
            System.IO.File.WriteAllLines(@"C:\Users\Owner\Documents\Visual Studio 2015\Projects\BigBuildingCapture\Files\Test1Output.txt", output);
        }

        //Accept all defaults
        [TestMethod]
        public void AcceptTheDefaults()
        {

        }

        //Create the gamemaster character - check to see if truly is gamemaster
        [TestMethod]
        public void CreateGameMasterCharacterAmy()
        {

        }

        //create another player
        [TestMethod]
        public void CreatePlayerJoe()
        {

        }

        //create another player
        [TestMethod]
        public void CreatePlayerSuni()
        {

        }

    }
}
