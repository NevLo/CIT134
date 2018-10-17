using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("\tParking Garage Terminal\n");
            bool running = true;
            double runningTotal = 0;


            while (running)
            {
                Console.Write("Please enter hours (Enter 0 to exit)\n>>> ");
                double hours = Double.Parse(Console.ReadLine());
                
                if (hours != 0)
                {
                    double current = CalculateCharges(hours);
                    runningTotal += current;
                    Console.WriteLine($"Current Reciept: {current:C} \nTotal Reciepts: {runningTotal:C}");
                }
                else
                {
                    running = false;
                }
            }
        }

        static double CalculateCharges(double hours)
        {
            
            if(hours <= 3)
            {
                return 2.00;
            }
            else
            {
                
                double charges = 2;
                double numH = hours - 3;
                while (charges <= 10.00 && numH > 0)
                {
                    charges += .5;
                    numH--;
                    

                }
                if(charges > 10)
                {
                    charges = 10;
                }
                return charges;
            }
        }


    }
}
