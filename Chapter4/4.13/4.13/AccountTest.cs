using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._13
{
    class AccountTest
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account("John Green", 50.00M);
            Account a2 = new Account("John Blue", -7.53M);

            DisplayAccount(a1);
            DisplayAccount(a2);

            Console.Write("\nEnter deposit amount for account1:");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account1 balance \n");
            a1.Deposit(depositAmount);

            DisplayAccount(a1);
            DisplayAccount(a2);

            Console.Write("\nEnter deposit amount for account2:");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account2 balance \n");
            a2.Deposit(depositAmount);

            DisplayAccount(a1);
            DisplayAccount(a2);




        }
        public static void DisplayAccount(Account a)
        {
            Console.WriteLine($"{a.Name}'s balance: {a.Balance}");
        }




    }
}
