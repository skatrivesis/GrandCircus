using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1
{
    class Person
    {
        private string name;
        private int id;
        private int age;

        //static variable/class variable
        //there's only one--it belons to Person
        private static int count = 0;

        public string Name { get => name; set => name = value; }
        public int Id { get => id; } //once constructed, id can't be changed
        public int Age { get => age; set => age = value; }
        public static int Count { get => count; } //encapsulating count and making it read only

        public Person(string name, int age)
        {
            this.name = name;
            this.id = count; //setting id to count so it wil dynamically add it
            count++; //incrementing for the next person
            this.age = age;
        }

        public override string ToString()
        {
            return $"{name} ({id})";
        }
    }
}
