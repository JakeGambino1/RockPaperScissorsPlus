using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Spock : Gesture
    {
        // member variables

        // constructor
        public Spock()
        {
            name = "spock";
        }
        // member methods
        public override bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice)
        {
            if (comparisonPlayerGestureChoice.name == "scissors" || comparisonPlayerGestureChoice.name == "rock")
            {
                return true;
            }
            return false;
        }
        // beats scissors and rock
    }
}
