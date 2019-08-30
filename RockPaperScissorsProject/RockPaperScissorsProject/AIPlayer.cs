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
        public static List<Gesture> gestureChoices = new List<Gesture>();
        public static Random random = new Random();

        // constructor
        public AIPlayer()
        {

        }

        // member method
        public override void ChooseName()
        {
            playerName = "Aspiring Skynet Soldier";
        }

        public override void ChooseGesture()
        {
            gestureChoices.Add(new Rock());
            gestureChoices.Add(new Paper());
            gestureChoices.Add(new Scissors());
            gestureChoices.Add(new Lizard());
            gestureChoices.Add(new Spock());

            int randomNumber = random.Next(0, gestureChoices.Count());
            gesture = gestureChoices[randomNumber];
            Console.WriteLine("AI player has chosen " + gesture + " to crush the mortal world!");
            Console.Clear();
        }
    }
}
