using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 
///  Contains dailyScore class
///  
/// </summary>


namespace BigBuildingCapture
{
    class ScoreKeeper
    {
        //called when a player is created only
        public ScoreKeeper(MainGame game)
        {
            connectedGame = game;
            CalendarOfScores = new SortedList<DateTime, int>(new DateTimeIComparer());
        }


        //Icomparer for the CalendarOfScores
        public class DateTimeIComparer : IComparer<DateTime>
        {
            public int Compare(DateTime x, DateTime y)
            {
                return x.CompareTo(y);
            }

        }



        //array of days and daily scores that is created when player is created
        public SortedList<DateTime, int> CalendarOfScores { get; }
        MainGame connectedGame;


        // Class ScoreKeeper
        //created when a player logs in on a new day
        public class dailyScore
        {
            public dailyScore(MainGame game)
            {
                current = 0;
                todaysDate = DateTime.Today;
            }

            public void addPoints(PointAdjustment adjustment)
            {
                int adjustmentValue = connectedGame.getAdjustmentValue(adjustment);
                current += adjustmentValue;
            }

            MainGame connectedGame;
            public int current { get; private set; }
            private DateTime todaysDate { get; }
        }

    }
    
}
