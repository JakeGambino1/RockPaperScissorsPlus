using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class Game
    {
        // member variables
        public Player p1;
        public Player p2;
        public int bestOfX;

        // constructor
        public Game()
        {
            
        }

        // member methods
        // Begin Game
        public void BeginMatch()
        {
            ChoosePlayers();
            p1.ChooseName();
            p2.ChooseName();
            ChooseBestOfX();
            BeginRound();
        }
        public void BeginRound()
        {
            p1.ChooseGesture();
            p2.ChooseGesture();
            CompareGestures();
            AddScoreToPlayer();
            Console.WriteLine(p1.score);
            Console.WriteLine(p2.score);
            CheckScoreForWinner();
            Console.ReadLine();
        }
        // Choose AI or Human Opponent
        public void ChoosePlayers()
        {
            Console.WriteLine("Will this be '1' or '2' players?");
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
            else
            {
                Console.WriteLine("please enter a valid option -- '1' or '2'");
            }
        }
        public void ChooseBestOfX()
        {
            Console.WriteLine("How long of a series do you want? Best of X (odd numbers only)");
            bestOfX = Convert.ToInt16(Console.ReadLine());
            if (bestOfX % 2 == 1)
            {
                return;
            }
            Console.WriteLine("You must choose an odd number of games");
            ChooseBestOfX();
        }
        // Compare Player Gestures to return Winning Player
        public bool CompareGestures()
        {
            p1.isWinner = false;
            p2.isWinner = false;
            if ((p1.gesture == "rock" && (p2.gesture == "scissors" || p2.gesture == "lizard")) ||
                (p1.gesture == "scissors" && (p2.gesture == "paper" || p2.gesture == "lizard")) ||
                (p1.gesture == "paper" && (p2.gesture == "rock" || p2.gesture == "spock")) ||
                (p1.gesture == "lizard" && (p2.gesture == "spock" || p2.gesture == "paper")) ||
                (p1.gesture == "spock" && (p2.gesture == "scissors" || p2.gesture == "rock")))
            {
                Console.WriteLine(p1.name + " won the round with " + p1.gesture + "!");
                p1.isWinner = true;
            }
            else if ((p2.gesture == "rock" && (p1.gesture == "scissors" || p1.gesture == "lizard")) ||
                (p2.gesture == "scissors" && (p1.gesture == "paper" || p1.gesture == "lizard")) ||
                (p2.gesture == "paper" && (p1.gesture == "rock" || p1.gesture == "spock")) ||
                (p2.gesture == "lizard" && (p1.gesture == "spock" || p1.gesture == "paper")) ||
                (p2.gesture == "spock" && (p1.gesture == "scissors" || p1.gesture == "rock")))
            {
                Console.WriteLine(p2.name + " won the round with " + p2.gesture + "!");
                p2.isWinner = true;
            }
            else
            { 
            Console.WriteLine("Tie! Go again!");
            }
            return false;
        }
        // Add Score to Winning Player
        public void AddScoreToPlayer()
        {
            if (p1.isWinner == true)
            {
                p1.score++;
            }
            else if (p2.isWinner == true)
            {
                p2.score++;
            }
            return;
        }
        // Check Score of Winning Player
        public void CheckScoreForWinner()
        {
            if (p1.score == (bestOfX + 1) / 2)
            {
                // declare winner
                Console.WriteLine(p1.name + " has won this epic match!");
            }
            else if (p2.score == (bestOfX +1) / 2)
            {
                Console.WriteLine(p2.name + " has won this epic match!");
            }

            Console.WriteLine(p1.name + " currently has a score of " + p1.score + ".");
            Console.WriteLine(p2.name + " currently has a score of " + p2.score + ".");
            while (p1.score != (bestOfX + 1) /2 && p2.score != (bestOfX + 1) / 2)
            {
                BeginRound();
                Console.ReadLine();
            }
        }
    }
}
