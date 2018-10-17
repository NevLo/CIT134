using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name Christian Pilley
//Date 10/17/18
//Desc GPA calculator
namespace _7._28
{
    class Program
    {
        static void Main(string[] args)
        {
            int GPA = 0;
            while (GPA != -1)
            {
                Console.Write("Please enter grade ( enter a number below zero to exit )\n>>> ");
                double grade = Double.Parse(Console.ReadLine());
                if (grade < 0)
                {
                    GPA = -1;
                    Console.WriteLine("Exiting");
                }
                else
                {
                    GPA = QualityPoints((int)grade / 10);
                    Console.WriteLine("Your GPA is : " + GPA);
                }
            }
        }
        static int QualityPoints(int grade)
        {
            int g = 4;
            switch(grade)
            {
                case 10:
                case 9:
                    g = 4;
                    break;
                case 8:
                    g = 3;
                    break;
                case 7:
                    g = 2;
                    break;
                case 6:
                    g = 1;
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    g = 0;
                    break;

            }
            return g;
        }
    }
}
