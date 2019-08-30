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
            name = "scissors";
        }

        public override bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "paper" || comparisonPlayerGestureChoice.name == "lizard")
            {
                return true;
            }
            return false;
        }
    }
}
