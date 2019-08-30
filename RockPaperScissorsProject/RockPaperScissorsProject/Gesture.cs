using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    public abstract class Gesture
    {
        public string name;
        
        public Gesture()
        {

        }

        public abstract bool GestureWinsAgainst(Gesture comparisonPlayerGestureChoice);
    }
}
