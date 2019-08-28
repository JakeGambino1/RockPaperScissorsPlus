using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public abstract class Player
    {
        // member variables
        public string gesture;
        public int score;

        // constructor
        public Player()
        {
            gesture = null;
            score = 0;
        }

        // member methods
        public abstract string ChooseGesture();
    }
}
