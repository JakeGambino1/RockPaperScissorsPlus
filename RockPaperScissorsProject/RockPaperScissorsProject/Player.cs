using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public abstract class Player
    {
        public string name;
        public Gesture gesture;
        public int score;
        public bool isWinner;

        public Player()
        {
            ChooseName();
            gesture = null;
            score = 0;
            isWinner = false;
        }
        public abstract void ChooseGesture();
        public abstract void ChooseName();
    }
}
