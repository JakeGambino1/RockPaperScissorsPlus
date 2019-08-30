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
            gestureName = "lizard";
        }

        public override bool WinsAgainst(Gesture comparisonPlayer)
        {
            if (comparisonPlayer.gestureName == "spock" || comparisonPlayer.gestureName == "paper")
            {
                return true;
            }
            return false;
        }
    }
}
