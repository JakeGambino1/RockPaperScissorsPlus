using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Rock : Gesture
    {
        // member variables

        // constructor
        public Rock()
        {
            name = "rock";
        }

        // member methods
        public override bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "scissors" || comparisonPlayerGestureChoice.name == "lizard")
            {
                return true;
            }
            return false;
        }

        // beats scissors and lizard
    }
}
