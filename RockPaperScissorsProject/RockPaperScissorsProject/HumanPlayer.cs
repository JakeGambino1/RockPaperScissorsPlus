using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class HumanPlayer : Player
    {
        // member variables
        public string gestureChoice;

        // constructor
        public HumanPlayer()
        {

        }
        // member methods
        public override void ChooseName()
        {
            Console.WriteLine("Choose a name for your existence.");
            name = Console.ReadLine();
            Console.WriteLine("Player confirmed as " + name);
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("What weapon will " + name + " choose?-- 'rock', 'paper', 'scissors', 'lizard', or 'spock'?");
            gestureChoice = Console.ReadLine();
            switch (gestureChoice)
            {
                case "rock":
                    gesture = "rock";
                    break;
                case "paper":
                    gesture = "paper";
                    break;
                case "scissors":
                    gesture = "scissors";
                    break;
                case "lizard":
                    gesture = "lizard";
                    break;
                case "spock":
                    gesture = "spock";
                    break;
                default:
                    Console.WriteLine("YOU FOOL! " + gestureChoice + " is not effective in this battle!");
                    ChooseGesture();
                    break;
            }
            Console.Clear();
        }
    }
}
