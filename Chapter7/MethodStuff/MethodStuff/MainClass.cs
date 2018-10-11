using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MethodStuff
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Phone phone = new Phone();
            Console.WriteLine(Phone.GetVersion());
            TurnOnPhone();
            Console.WriteLine(phone.GetRemainingBattery() + "%");

            bool result = phone.ChargeBattery(56.8);

            if (result)
            {
                Console.WriteLine("Phone now charged");
                Console.WriteLine(phone.GetRemainingBattery() + "%");
            }

        }
        /// <summary>
        /// Turn on the phone ( takes a minute )
        /// </summary>
        public static void TurnOnPhone()
        {
            Console.Write("Phone turning on");
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.WriteLine('.');
            //Thread.Sleep(1000);
            Console.WriteLine("Phone is on!");
        }

    }
}
