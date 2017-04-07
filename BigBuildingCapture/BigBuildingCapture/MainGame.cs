using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBuildingCapture
{
    // Main game must be created before any players are created.
    // Main game calls for configuration of: Point values, Flag hide time, Flag hunt time, end game time
    class MainGame
    {
        private static int POSSIBLE_ADJUSTMENTS_MAX = 50;
        
        public MainGame()
        {
            CurrentPointValues = new Dictionary<PointAdjustment, int>();
            setDefaultPointAdjustments();
        }

        //set default values contained in BbcCustomVariables.cs
        private void setDefaultPointAdjustments()
        {
            foreach (PointAdjustment pa in Enum.GetValues(typeof(PointAdjustment)))
            {
                CurrentPointValues.Add(pa, DefaultValues.PointAdjustmentValues[(int)pa]);
            }
        }

        //returns a list of the Point Adjustments and their current values (default if not set)
        public Dictionary<PointAdjustment, int> getPointAdjustmentTable(){
            return CurrentPointValues;
        }

        public int getAdjustmentValue(PointAdjustment adjustment)
        {
            return CurrentPointValues[adjustment];
        }


        //array that holds point values for each adjusted enum
        Dictionary<PointAdjustment, int> CurrentPointValues;
        public string Name { get; set; }
    }
}
