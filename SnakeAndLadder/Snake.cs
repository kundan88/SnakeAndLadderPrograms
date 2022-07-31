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
            int diceCount = 0;
            int position = 0;
            while (position != 100 && position <= 100)
            {
                int rollDice = RollDice();
                diceCount++;
                Console.WriteLine("PLayer got {0} on dice", rollDice);
                int checkOption = new Random().Next(0, 3);
                switch (checkOption)
                {
                    case 0:
                        position += 0;
                        Console.WriteLine("Player stayed at {0} position", position);
                        break;

                    case 1:

                        if (position != 100 && position < 100)
                        {
                            int currentPos = position + rollDice;
                            if (currentPos <= 100)
                            {
                                position += rollDice;
                            }
                        }
                        Console.WriteLine("Player moved to {0} position", position);
                        break;

                    case 2:
                        if (position >= rollDice)
                        {
                            position -= rollDice;
                        }
                        else
                        {
                            position = 0;
                        }
                        Console.WriteLine("Player moved back to {0} position", position);
                        break;
                }
            }
            Console.WriteLine("Number of times Dice rolled " + diceCount);

        
        }
    }

}





