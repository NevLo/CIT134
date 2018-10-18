using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name: Christian Pilley
//Desc: Midterm for CIT 134. Restaurant orders program.
//Date: 10/17/18 ::: 18:23
namespace OrderTest
{
    public class OrderTest
    {
        public static Random rand;
        public static void Main(string[] args)
        {
            rand = new Random();
            char selection;
            int orderEdit;
            int orderNum;
            bool endMenu = false;

            MyOrder order1 = new MyOrder(123, "Fred_Flintstone", "Beef", "Rice", "Bread", "Milk", 56.75M);
            UpdateTotal(order1.SubTotal);

            MyOrder order2 = new MyOrder(456, "Barney_Rubble", "Chicken", "Noodles", "Broth", "Soda", 48.25M);
            UpdateTotal(order2.SubTotal);

            MyOrder order3 = new MyOrder();

            do
            {
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
                Console.WriteLine("Welcome to Christian's Restaurant!\nPlease make a selection below...");
                Console.WriteLine(" (A) Begin an order\n"
                                + " (B) Delete an order\n"
                                + " (C) Display total of All orders\n"
                                + " (D) Exit\n");
                Console.Write(">>> ");

                selection = (Console.ReadLine().ToLower().Substring(0, 1))[0];
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
                switch (selection)
                {
                    case 'a':
                        orderNum = rand.Next(1000);
                        order3.OrderNum = orderNum;
                        Console.Write("Please enter your name (No Spaces!)\n>>> ");
                        order3.CustomerName = Console.ReadLine();

                        Console.Write("Please enter Item Name (No Spaces!)\n>>> ");
                        order3.Item1 = Console.ReadLine();
                        Console.Write($"Please enter the price of {order3.Item1}\n>>> ");
                        order3.SubTotal += Decimal.Parse(Console.ReadLine());
                        Console.Write("Please enter Item Name (No Spaces!)\n>>> ");
                        order3.Item2 = Console.ReadLine();
                        Console.Write($"Please enter the price of {order3.Item2}\n>>> ");
                        order3.SubTotal += Decimal.Parse(Console.ReadLine());
                        Console.Write("Please enter Item Name (No Spaces!)\n>>> ");
                        order3.Item3 = Console.ReadLine();
                        Console.Write($"Please enter the price of {order3.Item3}\n>>> ");
                        order3.SubTotal += Decimal.Parse(Console.ReadLine());
                        Console.Write("Please enter Item Name (No Spaces!)\n>>> ");
                        order3.Item4 = Console.ReadLine();
                        Console.Write($"Please enter the price of {order3.Item4}\n>>> ");
                        order3.SubTotal += Decimal.Parse(Console.ReadLine());

                        UpdateTotal(order3.SubTotal);
                        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
                        order3.DisplayOrder();

                        break;
                    case 'b':
                        Console.Write("Would you like to delete order 1 or 2?\n>>>");
                        orderEdit = int.Parse(Console.ReadLine());
                        if (orderEdit == 1)
                        {
                            order1.DeleteOrder();
                            order1.DisplayOrder();
                        }
                        else
                        {
                            order2.DeleteOrder();
                            order2.DisplayOrder();
                        }


                        break;
                    case 'c':
                        DisplayTotal();
                        break;
                    case 'd':

                        Console.WriteLine("Goodbye! And thanks for coming in!");
                        endMenu = true;
                        break;
                    default:
                        Console.WriteLine("Please try again:");
                        break;
                }
            } while (!endMenu);
        }

        public static void UpdateTotal(Decimal uVal)
        {
            MyOrder.Total += uVal;
        }
        public static void DisplayTotal()
        {
            Console.WriteLine($"Total: {MyOrder.Total}");
        }
    }
}
