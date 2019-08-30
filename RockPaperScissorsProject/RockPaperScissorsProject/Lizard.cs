using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Lizard : Gesture
    {
        // member variables

        // constructor
        public Lizard()
        {
            name = "lizard";
        }
        // member methods
        public override bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "spock" || comparisonPlayerGestureChoice.name == "paper")
            {
                return true;
            }
            return false;
        }
        // beats spock and paper
    }
}
