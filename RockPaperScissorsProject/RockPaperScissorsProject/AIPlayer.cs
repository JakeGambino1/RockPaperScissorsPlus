using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public class AIPlayer : Player
    {
        // member variables
        public static List<string> weaponsOfWar = new List<string>();
        public static Random randomNumber = new Random();


        // constructor
        public AIPlayer()
        {

        }

        // member method
        public override void ChooseName()
        {
            name = "Aspiring Skynet Soldier";
        }
        
        public override void ChooseGesture()
        {
            randomNumber.Next(6);
            Console.WriteLine(randomNumber);
            Console.ReadLine();
            if (Convert.ToInt32(randomNumber) == 1)
            {
                gesture = "rock";
            }
            else if (Convert.ToInt32(randomNumber) == 2)
            {
                gesture = "paper";
            }
            else if (Convert.ToInt32(randomNumber) == 3)
            {
                gesture = "scissors";
            }
            else if (Convert.ToInt32(randomNumber) == 4)
            {
                gesture = "lizard";
            }
            else if (Convert.ToInt32(randomNumber) == 5)
            {
                gesture = "spock";
            }
            else
            {
                Console.WriteLine("Please choose a valid option");
                ChooseGesture();
            }
        }
    }
}
