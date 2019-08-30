﻿using System;
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
        public Gesture gesture;
        public int score;
        public bool isWinner;

        // constructor
        public Player()
        {
            ChooseName();
            gesture = null;
            score = 0;
            isWinner = false;
        }

        // member methods
        public abstract void ChooseGesture();
        public abstract void ChooseName();
    }
}
