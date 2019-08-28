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
        Player p1 = new HumanPlayer();
        Player p2;

        // constructor
        public Game()
        {
            
        }

        // member methods

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
        
        // BeginGame
        public void BeginGame()
        {

        }

        // Players Choose Gestures


        // Compare Player Gestures to return Winning Player
        public static Player CompareGestures()
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

        }

        // Add Score to Winning Player
        public void AddScoreToPlayer(Player winnerOfGame)
        {
            winnerOfGame.score += 1;
        }

        // Check Score of Winning Player
        public void CheckWinCondition()
        {
            if (winnerOfGame.score == 2)
            {
                // declare winner
            }
            else
            {
                // continue to another game
            }
        }
    }
}
