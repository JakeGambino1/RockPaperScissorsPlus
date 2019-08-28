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
        int score;


        // constructor

        // member methods
        public void ChooseOpponent()
        {
            string choice = Console.WriteLine("Will you be playing against another person (p) or AI ('ai')?");
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
        public void CompareGestures(string p1.gesture, string p2.gesture)
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
    }
}
