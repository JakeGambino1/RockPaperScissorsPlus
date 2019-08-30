using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public abstract class Gesture
    {
        // member variables
        public string name;
        
        // constructor
        public Gesture()
        {

        }

        // member methods
        //public abstract bool GestureLosesTo();

        public abstract bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice);
    }
}
