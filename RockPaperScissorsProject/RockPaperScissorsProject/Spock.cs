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
            name = "spock";
        }

        public override bool WinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "scissors" || comparisonPlayerGestureChoice.name == "rock")
            {
                return true;
            }
            return false;
        }
    }
}
