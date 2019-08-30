using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Paper : Gesture
    {
        public Paper()
        {
            gestureName = "paper";
        }

        public override bool WinsAgainst(Gesture comparisonPlayerGesture)
        {
            if (comparisonPlayerGesture.gestureName == "rock" || comparisonPlayerGesture.gestureName == "spock")
            {
                return true;
            }
            return false;
        }
    }
}
