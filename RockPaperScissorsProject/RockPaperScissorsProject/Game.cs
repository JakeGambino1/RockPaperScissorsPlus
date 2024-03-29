﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Game
    {
        public Player p1;
        public Player p2;
        public int bestOfX;

        public Game()
        {
            
        }

        public void BeginMatch()
        {
            ChoosePlayers();
            ChooseBestOfX();
            BeginRound();
        }
        public void BeginRound()
        {
            p1.ChooseGesture();
            p2.ChooseGesture();
            CompareGestures();
            AddScoreToWinner();
            CheckRoundWinnerScore();
            Console.ReadLine();
        }
        public void ChoosePlayers()
        {
            Console.WriteLine("Will this be '0', '1', or '2' players?");
            string choice = Console.ReadLine();
            if (choice == "2")
            {
                p1 = new HumanPlayer();
                p2 = new HumanPlayer();
            }
            else if (choice == "1")
            {
                p1 = new HumanPlayer();
                p2 = new AIPlayer();
            }
            else if (choice == "0")
            {
                p1 = new AIPlayer();
                p2 = new AIPlayer();
            }
            else
            {
                Console.WriteLine("Please enter a valid option -- '0', '1', or '2' - Flamingo and Banana are not acceptible inputs.");
            }
        }
        public void ChooseBestOfX()
        {
            try
            {
                bestOfX = Convert.ToInt32(UI.GetUserInput("How long of a series do you want? Best of X (odd numbers only)"));
            }
            catch (Exception)
            {
                Console.WriteLine("Numbers only there, smart guy.");
            }

            if (bestOfX >= 3 && bestOfX % 2 == 1)
            {
                return;
            }
            else
            {
                Console.WriteLine("Input must be an odd number greater than or equal to 3");
                ChooseBestOfX();
            }
        }
        public bool CompareGestures()
        {
            p1.isWinner = false;
            p2.isWinner = false;
            if (p1.gesture.WinsAgainst(p2.gesture))
            {
                return p1.isWinner = true;
            }
            else if (p2.gesture.WinsAgainst(p1.gesture))
            {
                return p2.isWinner = true;
            }
            else if ((!p1.gesture.WinsAgainst(p2.gesture) && !p2.gesture.WinsAgainst(p1.gesture)))
            {
                Console.WriteLine("Tie! Go again!");
            }
            return false;
        }
        public void AddScoreToWinner()
        {
            if (p1.isWinner)
            {
                p1.score++;
            }
            else if (p2.isWinner)
            {
                p2.score++;
            }
            return;
        }
        public void CheckRoundWinnerScore()
        {
            if (p1.score == (bestOfX + 1) / 2)
            {
                Console.WriteLine(p1.playerName + " has won this epic match!");
            }
            else if (p2.score == (bestOfX + 1) / 2)
            {
                Console.WriteLine(p2.playerName + " has won this epic match!");
            }
            Console.WriteLine("Current score: \n" + p1.playerName + " " + p1.score + " - " + p2.score + " " + p2.playerName);
            while (p1.score != (bestOfX + 1) /2 && p2.score != (bestOfX + 1) / 2)
            {
                BeginRound();
                Console.ReadLine();
            }
        }
    }
}
