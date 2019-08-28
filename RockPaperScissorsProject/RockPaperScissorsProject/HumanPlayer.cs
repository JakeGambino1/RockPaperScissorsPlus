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
            // inherited?? score = 0;
        }
        // member methods
        public override string ChooseGesture()
        {
            Console.WriteLine("What is your weapon of choice? 'rock', 'paper', 'scissors', 'lizard', or 'spock'?");
            
                choice = Console.ReadLine();
            switch (choice)
            {
                case "rock":
                    return gesture = "rock";
                case "paper":
                    return gesture = "paper";
                case "scissors":
                    return gesture = "scissors";
                case "lizard":
                    return gesture = "lizard";
                case "spock":
                    return gesture = "spock";
                default:
                    Console.WriteLine("YOU FOOL! " + choice + " is not effective in this battle!");
                    string nextChance = ChooseGesture();
                    return nextChance;
            }
        }
    }
}
