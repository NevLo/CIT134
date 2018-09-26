using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13
{
    class Account
    {
        public string Name { get; set; }

        private decimal balance;

        public decimal Balance { get { return balance; }
            set {
                if (value > 0M)
                {
                    balance = value;
                }
            } }

        public Account(string n, decimal b)
        {
            Name = n;
            if (b > 0M)
            {
                Balance += b;
            }
        }

        public void Deposit(Decimal d)
        {
            Balance += d;
        }



    }
}
