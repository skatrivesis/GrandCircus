using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Inventory
    {
        List<Product> products = new List<Product>();

        public void InitializeInventory()
        {
            products.Add(new Product("Cutlass", 70));
            products.Add(new Product("Gold Cutlass", 160));
            products.Add(new Product("Parrot", 60));
            products.Add(new Product("Hand Hook", 20));
            products.Add(new Product("Pirate Boots", 12));
            products.Add(new Product("Cannon Ball", 2));
            products.Add(new Product("Pirate Hat", 5));
            products.Add(new Product("Spare Anchor", 180));
        }

        public void DisplayInventory()
        {
            int counter = 1;
            Console.WriteLine($" ID|{"Item", -25} | {"Cost in Dubloons"}");
            for (int i = 0; i < 50; i++) { Console.Write("="); }
            Console.WriteLine();

            foreach (Product item in products)
            {
                Console.WriteLine($" {counter} | {item}");
                counter++;
            }
        }
        public List<Product> ReturnProducts()
        {
            return products;
        }
    }
}
