using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBuildingCapture
{
    //after altering enums, be sure to alter the default values for the enum.
    public enum PointAdjustment
    {
        GoldenCapturesReward,
        HidFlag,
        WalkedGoodDistance,
        WalkedGreatDistance,
        WalkedAmazingDistance
    }

    //after altering enums, be sure to alter the default values for the enum.
    public enum GameStartEnd
    {
        HideTimeStart,
        HideTimeEnd,
        HuntTimeStart,
        HuntTimeEnd
    }

    public enum DistanceReward
    {
        GoodDistance,
        GreatDistance,
        AmazingDistance
    }


    public static class DefaultValues
    {
        public static int[] PointAdjustmentValues =
        {
            18,         //GoldenCaptureReward
            30,         //HidFlag
            15,         //WalkedGoodDistance
            20,         //WalkedGreatDistance
            25          //WalkedAmazingDistance

        };

        //use TimeSpan.parse to convert from string
        public static string[] GameStartEndValues =
        {
            "7:00",         //HideTimeStart
            "10:29:59",     //HideTimeEnd
            "10:30",        //HuntTimeStart
            "4:00",         //HuntTimeEnd
        };

        public static string HuntPeriodLengthValue = "0:15";
        public static int HuntPeriodCount = 2;


        public static double[] DistanceRewardValues =
        {
            .15,     //GoodDistance
            .20,     //GreatDistance
            .25      //AmazingDistance
        };

        public static int GoldenCaptureNumber = 3;
    }
}