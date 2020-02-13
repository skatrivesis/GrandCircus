using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class Car
    {
        private int id;
        private string make;
        private string model;
        private int year;
        private double price;

        public int Id { get => id; set => id = value; }
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public Car()
        {
            this.id = 0;
            this.make = "";
            this.model = "";
            this.year = 0;
            this.price = 0.0;
        }
        public Car(int id, string make, string model, int year, double price)
        {
            this.id = id;
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{id,-5}|{make, -15}|{model, -15}|{year, -5}|{price.ToString("c"), -15}|";
        }
    }
}
