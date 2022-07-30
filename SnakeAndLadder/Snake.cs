using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Snake
    {
        public static void RollDice()
        {
            int player = new Random().Next(1,6);
            Random random = new Random();

            int position = 0;
            Console.WriteLine("Player is at {0}", position);
            Console.WriteLine("Player gets: " + player);
        }
    }

}


