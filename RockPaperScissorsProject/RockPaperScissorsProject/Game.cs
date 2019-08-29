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
        public Player winningPlayer;


        // constructor
        public Game()
        {
            
        }

        // member methods
        // Begin Game
        public void BeginGame()
        {
            ChoosePlayers();
            p1.ChooseName();
            p2.ChooseName();
            ChooseBestOfX();
            p1.ChooseGesture();
            p2.ChooseGesture();
            Player winnerOfGame = CompareGestures();
                Console.WriteLine(winnerOfGame.name);
                Console.ReadLine();
            AddScoreToPlayer(winnerOfGame);
            CheckScoreForWinner(winnerOfGame);
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
                Console.WriteLine("please enter a valid option -- 'p' for player opponent or 'ai' for AI opponent.");
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
        public Player CompareGestures()
        {

            if ((p1.gesture == "rock" && (p2.gesture == "scissors" || p2.gesture == "lizard")) ||
                (p1.gesture == "scissors" && (p2.gesture == "paper" || p2.gesture == "lizard")) ||
                (p1.gesture == "paper" && (p2.gesture == "rock" || p2.gesture == "spock")) ||
                (p1.gesture == "lizard" && (p2.gesture == "spock" || p2.gesture == "paper")) ||
                (p1.gesture == "spock" && (p2.gesture == "scissors" || p2.gesture == "rock")))
            {
                Console.WriteLine(p1.name + " is the winner with " + p1.gesture + "!");
                return winningPlayer = p1;
            }
            else if ((p2.gesture == "rock" && (p1.gesture == "scissors" || p1.gesture == "lizard")) ||
                (p2.gesture == "scissors" && (p1.gesture == "paper" || p1.gesture == "lizard")) ||
                (p2.gesture == "paper" && (p1.gesture == "rock" || p1.gesture == "spock")) ||
                (p2.gesture == "lizard" && (p1.gesture == "spock" || p1.gesture == "paper")) ||
                (p2.gesture == "spock" && (p1.gesture == "scissors" || p1.gesture == "rock")))
            {
                Console.WriteLine(p2.name + " is the winner with " + p2.gesture + "!");
                return winningPlayer = p2;
            }
            else
            {
                return winningPlayer = null;
            }
        }

        // Add Score to Winning Player
        public int AddScoreToPlayer(Player winnerOfGame)
        {
            return winnerOfGame.score += 1;

        }

        // Check Score of Winning Player
        public void CheckScoreForWinner(Player winnerOfGame)
        {
            if (winnerOfGame.score == (bestOfX + 1) / 2)
            {
                // declare winner
                winnerOfGame.isWinner = true;
                Console.WriteLine(winnerOfGame + " has won this epic showdown");
            }
            else
            {
                // continue to another game
            }
        }
    }
}
