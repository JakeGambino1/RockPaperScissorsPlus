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
        public static int randomNumber = 1;

        // constructor
        public AIPlayer()
        {

        }

        // member methods
        public override string ChooseGesture()
        {
            // need random 1-5 generator
            return gesture = "rock";
        }

        //public static int GetRandomNumber()
        //{
        //    return int;
        //}

        //public static string ConvertRandomNumberToWeapon(randomNumber)
        //{

        //    //weaponsOfWar.Add("rock");
        //    //weaponsOfWar.Add("paper");
        //    //weaponsOfWar.Add("scissors");
        //    //weaponsOfWar.Add("lizard");
        //    //weaponsOfWar.Add("spock");

        //    //if (randomNumber == 1)
        //    //{
        //    //    p2.weapon = "rock";
        //    //}
        //    //else if (randomNumber == 2)
        //    //{
        //    //    p2.weapon = "paper";
        //    //}
        //    //else if (randomNumber == 3)
        //    //{
        //    //    p2.weapon = "scissors";
        //    //}
        //    //else if (randomNumber == 4)
        //    //{
        //    //    p2.weapon = "lizard";
        //    //}
        //    //else if (randomNumber == 5)
        //    //{
        //    //    p2.weapon = "spock";
        //    //}
        //}
    }
}
