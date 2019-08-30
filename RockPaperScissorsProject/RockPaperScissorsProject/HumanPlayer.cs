using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class HumanPlayer : Player
    {
        public string gestureChoice;

        public HumanPlayer()
        {

        }

        public override void ChooseName()
        {
            Console.WriteLine("Choose a name for your existence.");
            playerName = Console.ReadLine();
            Console.WriteLine("Player confirmed as " + playerName);
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("What weapon will " + playerName + " choose?-- 'rock', 'paper', 'scissors', 'lizard', or 'spock'?");
            gestureChoice = Console.ReadLine();
            switch (gestureChoice)
            {
                case "rock":
                    gesture = new Rock();
                    break;
                case "paper":
                    gesture = new Paper();
                    break;
                case "scissors":
                    gesture = new Scissors();
                    break;
                case "lizard":
                    gesture = new Lizard();
                    break;
                case "spock":
                    gesture = new Spock();
                    break;
                default:
                    Console.WriteLine("YOU FOOL! " + gestureChoice + " is not in the State-approved list of gestures");
                    ChooseGesture();
                    break;
            }
            Console.Clear();
        }
    }
}
