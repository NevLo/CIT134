using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MethodStuff
{
    public class Phone
    {
        private double batteryLife;
        /// <summary>
        /// Returns the Phone version.
        /// </summary>
        /// <returns>string</returns>
        public static string GetVersion()
        {
            return "Version 1.3.65a";
        }
        /// <summary>
        /// Returns battery life remaining.
        /// </summary>
        /// <returns></returns>
        public double GetRemainingBattery()
        {
            return batteryLife;
        }
        public bool ChargeBattery(double charge)
        {
            if(charge + batteryLife > 100)
            {
                return false;
            }
            else
            {
                Console.Write("Charging phone");
                Thread.Sleep(1000);
                Console.Write('.');
                Thread.Sleep(1000);
                Console.Write('.');
                Thread.Sleep(1000);
                Console.WriteLine('.');
                batteryLife += charge;
                return true;
            }
        }


    }
}
