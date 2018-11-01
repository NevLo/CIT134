using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    public class MyOrder
    {
        private static Decimal total;
        public static Decimal Total {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
        public string CustomerName { get; set; }
        public int OrderNum { get; set; }
        public Decimal SubTotal { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }


        public void DisplayOrder()
        {
            Console.WriteLine($"Order: {OrderNum}");
            Console.WriteLine($"   Customer Name: {CustomerName}\n");
            Console.WriteLine($"   Item 1: {Item1}");
            Console.WriteLine($"   Item 2: {Item2}");
            Console.WriteLine($"   Item 3: {Item3}");
            Console.WriteLine($"   Item 4: {Item4}\n");
            Console.WriteLine($"   Subtotal: {SubTotal:C}\n");

        }

        public MyOrder()
        {
            CustomerName = "";
            OrderNum = 0;
            SubTotal = 0;
            Item1 = "";
            Item2 = "";
            Item3 = "";
            Item4 = "";
        }
        public MyOrder (int ONum,string CName, string I1, string I2, string I3, string I4, Decimal STotal)
        {
            CustomerName = CName;
            OrderNum = ONum;
            SubTotal = STotal;
            Item1 = I1;
            Item2 = I2;
            Item3 = I3;
            Item4 = I4;
        }


        public void DeleteOrder()
        {
            CustomerName = "";
            Item1 = "";
            Item2 = "";
            Item3 = "";
            Item4 = "";
            Total -= SubTotal;
            SubTotal = 0;
        }





    }
}
