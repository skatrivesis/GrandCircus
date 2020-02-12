using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    class Student : Person
    {
        private int year;
        private int quarter;
        private string topic;

        public int Year { get => year; set => year = value; }
        public int Quarter { get => quarter; set => quarter = value; }
        public string Topic { get => topic; set => topic = value; }

        public Student(string name, int age, int year, int quarter, string topic)
            : base (name, age)
        {
            this.year = year;
            this.quarter = quarter;
            this.topic = topic;
        }

        public Student(string name, int age)
            : base (name, age)
        {
            topic = "Undecided";
            quarter = 0;
            year = 0;
        }

        public override string ToString()
        {
            //extending by using a call to base (reuse existing code)
            // and then adding more on.
            return base.ToString() + $" {topic} Q{quarter} {year}"; //this will travel up to the higher class and run to string
        }
    }
}
