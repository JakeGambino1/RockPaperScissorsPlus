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
            name = "paper";
        }

        public override bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "rock" || comparisonPlayerGestureChoice.name == "spock")
            {
                return true;
            }
            return false;
        }
    }
}
