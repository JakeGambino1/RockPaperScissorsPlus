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

        // Begin Game
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
            AddScoreToPlayer();
            CheckScoreForWinner();
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
                Console.WriteLine("please enter a valid option -- '1' or '2'");
            }
        }
        public void ChooseBestOfX()
        {
            try
            {
                Console.WriteLine("How long of a series do you want? Best of X (odd numbers only)");
                bestOfX = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception){}

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
            if ((p1.gesture == "rock" && (p2.gesture == "scissors" || p2.gesture == "lizard")) ||
                (p1.gesture == "scissors" && (p2.gesture == "paper" || p2.gesture == "lizard")) ||
                (p1.gesture == "paper" && (p2.gesture == "rock" || p2.gesture == "spock")) ||
                (p1.gesture == "lizard" && (p2.gesture == "spock" || p2.gesture == "paper")) ||
                (p1.gesture == "spock" && (p2.gesture == "scissors" || p2.gesture == "rock")))
            {
                Console.WriteLine(p1.name + " won the round with " + p1.gesture + "!" + p2.name + "'s " + p2.gesture + " was no match!");
                p1.isWinner = true;
            }
            else if ((p2.gesture == "rock" && (p1.gesture == "scissors" || p1.gesture == "lizard")) ||
                (p2.gesture == "scissors" && (p1.gesture == "paper" || p1.gesture == "lizard")) ||
                (p2.gesture == "paper" && (p1.gesture == "rock" || p1.gesture == "spock")) ||
                (p2.gesture == "lizard" && (p1.gesture == "spock" || p1.gesture == "paper")) ||
                (p2.gesture == "spock" && (p1.gesture == "scissors" || p1.gesture == "rock")))
            {
                Console.WriteLine(p2.name + " won the round with " + p2.gesture + "!" + p1.name + "'s " + p1.gesture + " was no match!");
                p2.isWinner = true;
            }
            else
            { 
                Console.WriteLine("Tie! Go again!");
            }
            return false;
        }
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
        public void CheckScoreForWinner()
        {
            if (p1.score == (bestOfX + 1) / 2)
            {
                Console.WriteLine(p1.name + " has won this epic match!");
            }
            else if (p2.score == (bestOfX + 1) / 2)
            {
                Console.WriteLine(p2.name + " has won this epic match!");
            }

            Console.WriteLine("Current score: \n" + p1.name + " " + p1.score + " - " + p2.score + " " + p2.name);
            while (p1.score != (bestOfX + 1) /2 && p2.score != (bestOfX + 1) / 2)
            {
                BeginRound();
                Console.ReadLine();
            }
        }
    }
}
