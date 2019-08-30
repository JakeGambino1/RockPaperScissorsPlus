using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Rock : Gesture
    {
        public Rock()
        {
            gestureName = "rock";
        }

        public override bool WinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.gestureName == "scissors" || comparisonPlayerGestureChoice.gestureName == "lizard")
            {
                return true;
            }
            return false;
        }
    }
}
