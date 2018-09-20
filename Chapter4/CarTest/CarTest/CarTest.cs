using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    public class CarTest
    {
        public static void Main(string[] args)
        {
            //Instantiation
            Car carOne = new Car();
            Car carTwo = new Car();
            Car carThree = new Car(2, "Black", 120000.00M);

            carOne.UpdateInfo(4, "white", 45000.00M);
            carTwo.UpdateInfo(5, "red", 2300.00M);
            


            carOne.DisplayInfo();
            carTwo.DisplayInfo();
            carThree.DisplayInfo();


            decimal c1Price = carOne.GetPrice();
            Console.WriteLine($"Price: {c1Price:C}");

            carOne.NumberOfWindows = 7;
            Console.WriteLine(carOne.NumberOfWindows);

            carThree.Model = "Gremlin";

            Console.WriteLine(carThree.Model);
        }
    }
}
