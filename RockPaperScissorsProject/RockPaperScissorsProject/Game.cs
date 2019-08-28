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
        public Player p2;
        public string winningPlayer;
        bool isWinner;

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
            }
            else if (choice == "ai")
            {
                p2 = new AIPlayer();
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
            // rock > scissors
            // scissors > paper
            // paper > rock
            // rock > lizard
            // lizard > spock
            // spock > scissors
            // scissors > lizard
            // lizard > paper
            // paper > spock
            // spock > rock
            return p1;

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
                isWinner = true;
            }
            else
            {
                // continue to another game
            }
        }
    }
}
