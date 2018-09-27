using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int winTotal = 0;
            while(count < 5)
            {
                Game game = new Game();
                if (game.IsWinner)
                {
                    winTotal++;
                }

                ++count;
            }
            if (winTotal >= 3)
            {
                Console.WriteLine("Yay!");
            }
            else
            {
                Console.WriteLine("Nay... Loser...");
            }
        }
    }
}
