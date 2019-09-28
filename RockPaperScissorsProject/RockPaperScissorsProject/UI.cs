using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsProject
{
    static class UI
    {
        public static string GetUserInput(string ask)
        {
            Console.WriteLine(ask);
            return Console.ReadLine();
        }
    }
}
