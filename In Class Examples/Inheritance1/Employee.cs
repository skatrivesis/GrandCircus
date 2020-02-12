using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    class Employee : Person
    {
        private string title;
        private double salary;

        public string Title { get => title; set => title = value; }
        public double Salary { get => salary; set => salary = value; }
    
        public Employee(string name, int age, string title, double salary)
            : base (name, age)
        {
            this.title = title;
            this.salary = salary;
        }

        public Employee(string name, int age)
            : base (name, age)
        {
            title = "n/a";
            salary = 0.0;
        }

        public void GiveRaise(double percent)
        {
            salary *= 1 + percent;
        }

        public override string ToString()
        {
            return base.ToString() + $" {title} {salary.ToString("C")}";
        }
    }
}
