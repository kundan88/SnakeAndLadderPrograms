using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Snake
    {
        public static int RollDice()
        {
            return new Random().Next(1, 7);
            Random random = new Random();
        }

        public static void rollDice() 
        {
            int position = 0;
            int checkOption = new Random().Next(0, 3);
            int rollDice = RollDice();
            Console.WriteLine("PLayer got {0} on dice", rollDice);

            switch (checkOption)
            {
                case 0:
                    position += 0;
                    Console.WriteLine("Player stayed at {0} position", position);
                    break;
                case 1:
                    position += rollDice;
                    Console.WriteLine("Player moved to {0} position", position);
                    break;
                case 2:
                    if (position >= rollDice)
                    {
                        position -= rollDice;
                    }
                    Console.WriteLine("Player moved back to {0} position", position);
                    break;
            }


        }
    }

}





