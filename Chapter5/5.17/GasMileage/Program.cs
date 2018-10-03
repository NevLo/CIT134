using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//Desc: Gas mileage calculator
//Date: 10-3-18 :: 15:28
namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles, gallons;
            float mpg = 0;
            float trips = 0;
            bool run = true;
            while (run)
            {
                Console.WriteLine("Please enter your miles:");
                miles = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your gallons:");
                gallons = int.Parse(Console.ReadLine());

                float instMpg = miles * 1.0f / gallons * 1.0F;

               
                mpg *= trips;
                mpg += instMpg;
                trips++;
                mpg /= trips;
                Console.WriteLine($"Your mpg for this trip was {instMpg:f}\nYour mpg for all trips is {mpg:f}");

            }



        }
    }
}
