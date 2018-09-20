using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTest
{
    public class Car
    {
        private int numberOfWheels;
        private string color;
        private decimal price;
        private int numberOfWindows;
        

        //Default Constructor
        public Car() { }

        //Overloaded constructor

        public Car(int numberOfWheels, string color, decimal price)
        {
            this.numberOfWheels = numberOfWheels;
            this.color = color;
            this.price = price;
        }
        // Return the price of the car
        public decimal GetPrice()
        {
            return price;


        }

        //autoimplementing property
        public string Model { get; set; }


        //number of windows property
        public int NumberOfWindows
        {
            get
            {
                return numberOfWindows;
            }
            set
            {
                numberOfWindows = value;
            }
        }

        //Writes all the car info to console
        public void DisplayInfo()
        {
            Console.WriteLine("\nColor: {0}",color);
            Console.WriteLine("Price: {0:C}",price);
            Console.WriteLine("Wheels: {0}", numberOfWheels);

        }

        //Updates all the car info
        public void UpdateInfo(int n, string c, decimal p)
        {
            numberOfWheels = n;
            color = c;
        
            if(p < 5000.00M)
            {
                price = 5000.00M;
            }
            else
            {
                price = p;
            }
        }
    }
}
