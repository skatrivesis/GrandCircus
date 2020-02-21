using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminal
{
    public class Product
    {
        private string productName;
        private double productPrice;

        public Product(string productName, double productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public string ProductName { get => productName; set => productName = value; }
        public double ProductPrice { get => productPrice; set => productPrice = value; }

        public override string ToString()
        {
            return $"{productName, -25}| {productPrice:F2}";
        }
    }
}
