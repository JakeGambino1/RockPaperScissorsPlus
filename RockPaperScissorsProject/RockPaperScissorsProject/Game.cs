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
        public Player p1 = new HumanPlayer();
        public Player p2 = new AIPlayer();

        // constructor
        public Game()
        {
            
        }

        // member methods
        // Begin Game
        public void BeginGame()
        {
            ChooseOpponent();
            p1.ChooseGesture();
            p2.ChooseGesture();
            Player winnerOfGame = CompareGestures();
                Console.WriteLine(winnerOfGame);
                Console.ReadLine();
            AddScoreToPlayer(winnerOfGame);
            CheckScoreForWinner(winnerOfGame);
        }

        // Choose AI or Human Opponent
        public void ChooseOpponent()
        {
            Console.WriteLine("Will you be playing against another person (p) or AI ('ai')?");
            string choice = Console.ReadLine();
            if (choice == "p")
            {
                p2 = new HumanPlayer();
                Console.WriteLine(p2);
            }
            else if (choice == "ai")
            {
                p2 = new AIPlayer();
                Console.WriteLine(p2);
            }
            else
            {
                Console.WriteLine("please enter a valid option -- 'p' for player opponent or 'ai' for AI opponent.");
            }
        }
        // Players Choose Gesture

        // Compare Player Gestures to return Winning Player
        public Player CompareGestures()
        {

            if (p1.gesture == "rock" && (p2.gesture == "scissors" || p2.gesture == "lizard"))
            {
                return p1;
            }
            else if (p2.gesture == "rock" && (p1.gesture == "scissors" || p1.gesture == "lizard"))
            {
                return p2;
            }
            else if (p1.gesture == "scissors" && (p2.gesture == "paper" || p2.gesture == "lizard"))
            {
                return p1;
            }
            else if (p2.gesture == "scissors" && (p1.gesture == "paper" || p1.gesture == "lizard"))
            {
                return p2;
            }
            else if (p1.gesture == "paper" && (p2.gesture == "rock" || p2.gesture == "spock"))
            {
                return p1;
            }
            else if (p2.gesture == "paper" && (p1.gesture == "rock" || p1.gesture == "spock"))
            {
                return p2;
            }
            else if (p1.gesture == "lizard" && (p2.gesture == "spock" || p2.gesture == "paper"))
            {
                return p1;
            }
            else if (p2.gesture == "lizard" && (p1.gesture == "spock" || p1.gesture == "paper"))
            {
                return p2;
            }
            else if (p1.gesture == "spock" && (p2.gesture == "scissors" || p2.gesture == "rock"))
            {
                return p1;
            }
            else if (p2.gesture == "spock" && (p1.gesture == "scissors" || p1.gesture == "rock"))
            {
                return p2;
            }
            else
            {
                return null;
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
            if (winnerOfGame.score == 2)
            {
                // declare winner
                p1.isWinner = true;
            }
            else
            {
                // continue to another game
            }
        }
    }
}
