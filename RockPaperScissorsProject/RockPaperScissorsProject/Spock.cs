using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Spock : Gesture
    {
        public Spock()
        {
            gestureName = "spock";
        }

        public override bool WinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.gestureName == "scissors" || comparisonPlayerGestureChoice.gestureName == "rock")
            {
                return true;
            }
            return false;
        }
    }
}
