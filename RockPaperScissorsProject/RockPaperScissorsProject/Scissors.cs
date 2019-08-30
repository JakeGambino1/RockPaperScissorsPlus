using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Scissors : Gesture
    {
        // member variables

        // constructor
        public Scissors()
        {
            name = "scissors";
        }
        // member methods
        public override bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "paper" || comparisonPlayerGestureChoice.name == "lizard")
            {
                return true;
            }
            return false;
        }
        // beats paper and lizard
    }
}
