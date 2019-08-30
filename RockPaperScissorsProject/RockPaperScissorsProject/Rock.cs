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
            name = "rock";
        }

        public override bool WinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "scissors" || comparisonPlayerGestureChoice.name == "lizard")
            {
                return true;
            }
            return false;
        }
    }
}
