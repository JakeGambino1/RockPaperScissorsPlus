using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    class AIPlayer : Player
    {
        // member variables

        // constructor
        public AIPlayer()
        {
            gesture = ChooseGesture();
            // Inherited ??? score = 0;
        }

        // member methods
        public override string ChooseGesture()
        {
            // Need random 1-5 generator

            return "choice";
        }
    }
}
