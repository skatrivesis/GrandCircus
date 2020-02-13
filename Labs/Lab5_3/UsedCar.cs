using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage { get => mileage; set => mileage = value; }

        public UsedCar() : base()
        {
            this.mileage = 0;
        }

        public UsedCar(int id, string make, string model, int year, double price, double mileage) : base(id, make, model, year, price)
        {
            this.mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $"(Used) {mileage.ToString("n"), -15} miles|";
        }
    }
}
