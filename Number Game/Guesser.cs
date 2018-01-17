using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Game
{
    class Guesser
    {
        public static bool PlayGame()
        {
            Random rnd = new Random();
            int guess = 0;
            int minNumber = 1;
            int maxNumber = 10;
            while (true)
            {
                guess = rnd.Next(minNumber, maxNumber);
                Console.WriteLine("Is it " + guess + "?");
                Console.WriteLine("(yes, higher, lower)");
                var clue = Console.ReadLine();
                try
                {
                    if ("yes" == clue)
                    {
                        Console.WriteLine("Yay! Want to play again?");
                        Console.WriteLine("(y, n)");
                        var answer = Console.ReadLine();
                        try
                        {
                            if ("y" == answer)
                            {
                                return true;
                            }
                            if ("n" == answer)
                            {
                                return false;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("What?");
                        }
                        
                    }
                    if ("higher" == clue)
                    {
                        minNumber = guess + 1;
                    }
                    if ("lower" == clue)
                    {
                        maxNumber = guess - 1;
                    }
                    if (minNumber == maxNumber)
                    {
                        Console.WriteLine("According to your hints, the answer is " + minNumber + ".");
                    }
                    if (minNumber == 9)
                    {
                        Console.WriteLine("The answer should be 9, it's the highest number between one and ten.");
                    }
                    if (maxNumber == 1)
                    {
                        Console.WriteLine("The answer should be 1, it's the lowest number between one and ten.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("What?");
                }
            }
        }
    }
}
