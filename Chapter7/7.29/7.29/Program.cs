using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Name: Christian Pilley
//Desc: coin tosser
//Date: 10/17/18
namespace _7._29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my coin tosser app!\n");
            bool CorrectInput = false;
            int hCount = 0;
            int tCount = 0;
            while (!CorrectInput)
            {
                Console.WriteLine("Press T to toss a coin, or Q to exit");
                Console.Write(">>>");
                char c = Console.ReadKey().KeyChar;

                if (c.Equals('T') || c.Equals('t'))
                {
                    if (tossCoin())
                    {
                        hCount++;
                    }
                    else
                    {
                        tCount++;
                    }
                    Console.WriteLine($"Heads: {hCount}");
                    Console.WriteLine($"Tails: {tCount}");
                }
                else if (c.Equals('Q') || c.Equals('q'))
                {
                    CorrectInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter T or Q");
                }

            }
        }


        static bool tossCoin()
        {
            Random rand = new Random();
            double r = rand.NextDouble();
            if(r >= .5)
            {
                Console.Write("\nTossing");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Console.WriteLine("\nHeads!");
                return true;
            }
            else
            {
                Console.Write("\nTossing");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Thread.Sleep(500);
                Console.Write(".");
                Console.WriteLine("\nTails!");
                return false;
            }
        }
    }
}
