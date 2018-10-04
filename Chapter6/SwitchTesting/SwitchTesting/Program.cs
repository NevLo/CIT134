using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Please enter an integer between 1 and 5");
            Console.Write(">>>");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    //for (int x = 0; x < num; x++) { Console.WriteLine($"You entered {num}"); }
                    //break;
                case 2:
                    //for (int x = 0; x < num; x++) { Console.WriteLine($"You entered {num}"); }
                    //break;
                case 3:
                    //for (int x = 0; x < num; x++) { Console.WriteLine($"You entered {num}"); }
                    //break;
                case 4:
                    //for (int x = 0; x < num; x++) { Console.WriteLine($"You entered {num}"); }
                    //break;
                case 5:
                    for (int x = 0; x < num; x++) { Console.WriteLine($"You entered {num}"); }
                    break;
                default:
                    Console.WriteLine("You no risten!!!");
                    break;


            }
            */
            Console.WriteLine("Please enter A, B, or C");
            Console.Write(">>>");
            string input = (Console.ReadLine().ToUpper());
           
            switch (input)
            {
              
                case "A":
                    Console.WriteLine( "Good choice! A is great");
                    break;
                case "B":
                    Console.WriteLine("Ehhhh, not my favorite...");
                    Console.WriteLine("But you found the magic man");
                    break;
                case "C":
                    Console.WriteLine("Whoah!!!");

                    break;
                default:
                    Console.WriteLine("You no risten!!!");
                    break;


            }



        }
    }
}
