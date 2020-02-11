using System;
using System.Collections.Generic;

namespace Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Inigo Montoya", 32);
            Student s = new Student("Stavin Braskit", 6, 2015, 4, "Java");

            //polymorphism allows us to use a more specific type as a more general
            Person p2 = new Student("Lady Witherell", 4, 2016, 2, "Java");

            //but not the opposite
            //Student s2 = new Person("Kincaid", 3, 1);

            //because I can treat subclasses (derived classes) as the more general
            //I can keep them in a collection of the superclass
            List<Person> people = new List<Person>();
            people.Add(p);
            people.Add(s);
            people.Add(p2);

            people.Add(new Employee("Socrates Katrivesis",28, "Professional Idiot", 2.50));
            people.Add(new Employee("Andrew Steward", 29));

            foreach (Person pe in people)
            {
                //if I need to use more specific properties/methods
                //I need to check if it's the derived class first
                if (pe is Employee)
                {
                    //I know it's the derived class Employee
                    //I still have to cast with proper Order of Operations
                    ((Employee)pe).GiveRaise(.1);
                }
                Console.WriteLine(pe.ToString());
            }
        }
    }
}
