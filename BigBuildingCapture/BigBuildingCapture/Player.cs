using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBuildingCapture
{
    class Player
    {
        //constructor - called when a player is created
        public Player(MainGame game)
        {
            connectedGame = game;
            playerScore = new ScoreKeeper(game);
        }



        //class variables
        public string playerName { get; set; }
        private ScoreKeeper playerScore;
        private MainGame connectedGame;
        private bool gameMaster;
        public flagStruct playersFlag; //need to think about initialization
        

    }
}


//how to make it so that only game master can change main game

/*
Bool enterConfigureMainGame();
Double distanceWalked();

Sep file:
Bool canPlayerHunt();

Separate file:
Bool canPlayerHide();

SetFlagForTheDay(playersFlag);

    */