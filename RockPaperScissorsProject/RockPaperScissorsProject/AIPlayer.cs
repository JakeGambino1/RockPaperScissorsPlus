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
        public static List<string> gestureChoices = new List<string>();
        public static Random random = new Random();

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
            gestureChoices.Add("rock");
            gestureChoices.Add("paper");
            gestureChoices.Add("scissors");
            gestureChoices.Add("lizard");
            gestureChoices.Add("spock");

            int randomNumber = random.Next(0, gestureChoices.Count());
            gesture = gestureChoices[randomNumber];
            Console.WriteLine("AI player has chosen " + gesture + " to crush the mortal world!");
        }
    }
}
