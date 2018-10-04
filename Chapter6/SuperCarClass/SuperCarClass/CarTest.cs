using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCarClass
{
    public class CarTest
    {
        static void Main(string[] args)
        {

            bool endLoop = false;

            do{
                Car car = new Car();

                Console.Write("Please enter a color\n>>>");
                car.Color = Console.ReadLine();

                Console.Write("How many wheels\n>>>");
                car.NumberOfWheels = int.Parse(Console.ReadLine());

                Console.Write("What Model?\n>>>");
                car.Model = Console.ReadLine();

                car.DisplayInfo();
                Random rand = new Random();
                decimal price = (decimal) rand.NextDouble();

                Console.WriteLine("Price: " + price * 25000);
                Console.Write("(B)uy or (S)tart-over:\n>>>");
                string input = Console.ReadLine();

                if (input.Equals("B"))
                {
                    endLoop = !endLoop; 
                }
               



            } while (!endLoop);
            Console.WriteLine("Thanks for making me rich!");



        }
    }
}
