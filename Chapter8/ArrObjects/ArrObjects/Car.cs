using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrObjects
{
    public class Car
    {
        
        public short numOfWindows { get; set; }
        public char Color { get; set; }
        public float Price { get; set; }


        // Array Property
        public int[] Fuses { get; set; }


        // Overloaded constructor
        public Car(short n, char c, float p, Random rand)
        {
            numOfWindows = n;
            Color = c;
            Price = p;
            Fuses = new int[10];
            for(int i = 0; i < Fuses.Length; i++)
            {
                Fuses[i] = rand.Next(5, 51);
            }
        }

    }
}
