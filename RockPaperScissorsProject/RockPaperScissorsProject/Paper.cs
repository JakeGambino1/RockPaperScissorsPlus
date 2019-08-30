using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Paper : Gesture
    {
        // member variables

        // constructor
        public Paper()
        {
            name = "paper";
        }

        // member methods
        public override bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "rock" || comparisonPlayerGestureChoice.name == "spock")
            {
                return true;
            }
            return false;
        }

        // beats rock and spock
    }
}
