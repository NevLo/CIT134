using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//name: Christian Pilley
//desc: Creates blocks of different sizes
//date: 10/10/18 4:15
namespace _6._26
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; ++i)
            {
                for (int j = 1; j <= 3; ++j)
                {
                    for (int k = 1; k <= 4; ++k)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= 2; ++i)
            {
                for (int j = 1; j <= 7; ++j)
                {
                    for (int k = 1; k <= 9; ++k)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
