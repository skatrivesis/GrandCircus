using System;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1000, "Steve", "Katrivesis", "Software Engineer", 2.0);
            Employee emp2 = new Employee(1001, "Bob", "Saget", "Actor", 3.0);
            Employee emp3 = new Employee(1002, "J", "B", "Claw", 2.0);

            emp2.GiveRaise(2000);
            emp3.Promote("Retired", 3000);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);
            Console.WriteLine(emp3);
        }
    }
}
