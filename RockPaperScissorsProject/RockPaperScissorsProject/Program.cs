﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game gameStart = new Game();
            gameStart.BeginMatch();
        }
    }
}
