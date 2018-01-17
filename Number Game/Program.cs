using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Guesser guesser = new Guesser();
                Console.WriteLine("Think of a number between one and ten and I'll try to guess.");
                Console.WriteLine("Did you think of one?");
                Console.WriteLine("(Press any key)");
                Console.ReadKey();
                Console.Clear();
                Guesser.PlayGame();
                if (Guesser.PlayGame())
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
