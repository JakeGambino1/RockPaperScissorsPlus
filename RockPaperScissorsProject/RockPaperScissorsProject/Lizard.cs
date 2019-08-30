using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Lizard : Gesture
    {
        public Lizard()
        {
            name = "lizard";
        }

        public override bool WinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "spock" || comparisonPlayerGestureChoice.name == "paper")
            {
                return true;
            }
            return false;
        }
    }
}
