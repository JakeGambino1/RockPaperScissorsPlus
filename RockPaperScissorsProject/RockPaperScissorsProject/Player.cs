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
        public string name;
        public string gesture;
        public int score;
        public bool isWinner;
        public bool isTie;

        // constructor
        public Player()
        {
            gesture = null;
            score = 0;
            isWinner = false;
        }

        // member methods
        public abstract void ChooseGesture();

        public abstract void ChooseName();
    }
}
