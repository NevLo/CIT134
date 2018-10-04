using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCarClass
{
    public class Car
    {
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public string Model { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Color: {Color}\nNumber of Wheels: {NumberOfWheels}\nModel: {Model}");
        }


    }
}
