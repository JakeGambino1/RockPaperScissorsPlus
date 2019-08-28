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

        // constructor
        public Player()
        {
            gesture = null;
        }

        // member methods
        public abstract string ChooseGesture();
    }
}
