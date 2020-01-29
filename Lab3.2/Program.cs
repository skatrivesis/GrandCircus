using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> inventory = new Dictionary<string, double>();
            inventory["apple"] = 0.99;
            inventory["pinapple"] = 2.99;
            inventory["strawburrries"] = 3.00;
            inventory["snow"] = 0.00;
            inventory["single almond"] = 0.02;
            inventory["almond joy"] = 0.75;
            inventory["piece of carrot"] = 0.43;
            inventory["shoes full of beets"] = 5.00;
            inventory["box of cereal"] = 3.49;
            inventory["can of beans"] = 1.99;
            inventory["Mike DuBose"] = 99999999999.99; //aka priceless

            ArrayList cartItem = new ArrayList();
            ArrayList cartPrice = new ArrayList();

            string input;
            bool flag;

            Console.WriteLine("\nWelcome to Soc's Shop. We sell Junk and Fresh Produce\n");

            do
            {
                //display inventory
                DisplayInventory(inventory);

                //get user input for cart
                input = StrInput("\nPlease input what you would like to add to cart: ");

                if (inventory.ContainsKey(input))
                {
                    cartItem.Add(input);
                    cartPrice.Add((double)inventory[input]);
                }
                else
                {
                    Console.WriteLine("Item does not exist. Please try again with a valid item.");
                }

                flag = RunAgain();

            } while (flag) ;

            //output cart
            DisplayCart(cartItem, cartPrice);
            //cart total
            CalculateTotal(cartPrice);
        }

        private static void CalculateTotal(ArrayList cartPrice)
        {
            double sum = 0.0;

            for (int i = 0; i < cartPrice.Count; i++)
            {
                sum += (double)cartPrice[i];
            }
            Console.WriteLine($"\nYour total is: ${sum:F2}");
        }

        private static void DisplayInventory(Dictionary<string, double> inventory)
        {
            Console.WriteLine($"{"Item",-20} | {"Price", -20}");
            Console.WriteLine("=====================================================");
            foreach (KeyValuePair<string, double> kvPair in inventory)
            {
                Console.WriteLine($"{kvPair.Key,-20} > ${kvPair.Value,-20}");
            }
        }

        private static void DisplayCart(ArrayList cartItem, ArrayList cartPrice)
        {
            for (int i = 0; i < cartItem.Count; i++)
            {
                Console.WriteLine($"{i + 1,3} {cartItem[i],-10} ${cartPrice[i], -5}");
            }
        }

        private static string StrInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        private static bool RunAgain()
        {
            Console.WriteLine("\nWould you like to add another item? <ENTER> to add another or <C> for Checkout :\n");

            if (Console.ReadKey(true).Key == ConsoleKey.C)
            {
                Console.WriteLine("Here is your shopping cart!!");
                return false;
            }
            else
            {
                Console.WriteLine("Let us run it again!\n");
                return true;
            }
        }
    }
}
