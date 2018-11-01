using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrObjects
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            try 
            {
                Car[] cars = new Car[3];
                BuildCars(cars, rand);

                foreach(Car c in cars)
                {
                    Console.Write($"\n{c.Price:C}\t");
                    Console.Write(c.Color + "\t");
                        Console.WriteLine(c.numOfWindows);
                        //Console.WriteLine(cars[x].Fuses);
                        for(int i = 0; i < c.Fuses.Length; i++)
                        {
                            Console.Write(c.Fuses[i] + " ");
                        }
                        Console.WriteLine();
                }

                //for (int x = 0; x < cars.GetLength(0); x++)
                //{
                //    Console.Write($"\n{cars[x].Price:C}\t");
                //    Console.Write(cars[x].Color + "\t");
                //    Console.WriteLine(cars[x].numOfWindows);
                //    //Console.WriteLine(cars[x].Fuses);
                //    for(int i = 0; i < cars[x].Fuses.Length; i++)
                //    {
                //        Console.Write(cars[x].Fuses[i] + " ");
                //    }
                //    Console.WriteLine();
                //}
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e);
            }
            Console.WriteLine("\nGoodBye!");


        }

        public static void BuildCars(Car[] cars, Random rand)
        {
            cars[0] = new Car(7, 'a', 19.99F, rand);
            cars[1] = new Car(8, 'c', 989898F, rand);
            cars[2] = new Car(69, 'x', 90000F, rand);
        }
    }
}
