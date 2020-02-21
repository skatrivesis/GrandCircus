using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Transaction
    {
        const double TAX_RATE = 0.06;
        private double subtotal = 0;
        private double grandTotal = 0;

        Dictionary<string, double> individualSubtotal = new Dictionary<string, double>();

        public void CalculateTransaction(List<Product> products, Dictionary<string, int> cart)
        {
            SubtotalPerItem(products, cart);

            foreach (KeyValuePair<string, double> item in individualSubtotal)
            {
                subtotal += individualSubtotal[item.Key];
            }
            grandTotal = GrandTotal();
        }
        public double GrandTotal()
        {
            return GetTax() + subtotal;
        }
        public void ClearTransaction(Dictionary<string, int> cart)
        {
            individualSubtotal.Clear();
            cart.Clear();
            subtotal = 0;
            grandTotal = 0;
        }
        public void CalcChange(double cash)
        {
            if (cash == grandTotal)
            {
                Console.WriteLine("\nWe are all settled up! No Change needed!\n");
            }
            else
            {
                Console.WriteLine($"\nYou get {cash - grandTotal:N2} dubloons back.... dont spend them all in one port!\n");
            }
        }
        public void DisplayReciept()
        {
            Console.WriteLine($"{"Item",-25}| {"Price"}");
            for (int i = 0; i < 50; i++) { Console.Write("="); }
            Console.WriteLine();
            foreach (KeyValuePair<string, double> item in individualSubtotal)
            {
                Console.WriteLine($"{item.Key,-25}| {item.Value:N2} Dubloons");
            }
            Console.WriteLine($"\n{"Subtotal",25}: {subtotal:N2} Dubloons");
            Console.WriteLine($"{"Tax",25}: {GetTax():N2} Dubloons");
            Console.WriteLine($"{"Grand Total",25}: {grandTotal:N2} Dubloons");
        }
        public double GetTax()
        {
            return subtotal * TAX_RATE;
        }
        public void SubtotalPerItem(List<Product> products, Dictionary<string, int> cart)
        {
            foreach (KeyValuePair<string, int> item in cart)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (item.Key == products[i].ProductName)
                    {
                        //adding to dictionary: Item name, Subtotal
                        individualSubtotal.Add($"{item.Key} x{item.Value}", products[i].ProductPrice * item.Value);
                    }
                }
            }
        }
    }
}
