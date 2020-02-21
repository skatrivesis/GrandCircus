using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Cart
    {
        //cart contains name and qty.
        Dictionary<string, int> cart = new Dictionary<string, int>();

        public void CartAdd(List<Product> inventory, int selection, int qty)
        {
            if (!cart.ContainsKey(inventory[selection].ProductName))
            {
                cart.Add(inventory[selection].ProductName, qty);
            }
            else
            {
                cart[inventory[selection].ProductName] += qty;
            }
        }

        public void DisplayCart()
        {
            Console.WriteLine("\nHere is what you have in your treasure chest\n");
            foreach (KeyValuePair<string, int> item in cart)
            {
                Console.WriteLine($"{item.Key, -25}|{item.Value}");
            }
            Console.WriteLine();
        }
        public Dictionary<string, int> ReturnCart()
        {
            return cart;
        }
    }
}
