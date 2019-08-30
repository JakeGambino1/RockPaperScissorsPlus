using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Scissors : Gesture
    {
        public Scissors()
        {
            gestureName = "scissors";
        }

        public override bool WinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.gestureName == "paper" || comparisonPlayerGestureChoice.gestureName == "lizard")
            {
                return true;
            }
            return false;
        }
    }
}
