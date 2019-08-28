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
        public string choice;

        // constructor
        public HumanPlayer()
        {
            gesture = ChooseGesture();
        }
        // member methods
        public override string ChooseGesture()
        {
            Console.WriteLine("What is your weapon of choice? 'rock', 'paper', 'scissors', 'lizard', or 'spock'?);
            choice = Console.ReadLine();
            switch (choice)
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

            }
        }
    }
}
