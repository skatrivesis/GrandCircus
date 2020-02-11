using System;
using System.Collections.Generic;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> geom = new List<Shape>();

            geom.Add(new Circle(10));
            geom.Add(new Rectangle(3, 5));
            geom.Add(new Rectangle(8.5, 11));
            geom.Add(new Circle(15));
            geom.Add(new Rectangle(23, 41));

            foreach (Shape s in geom)
            {
                Console.WriteLine(s.ToString());
                Console.WriteLine($"Perimeter: {s.CalcPerimeter()}");
                Console.WriteLine($"Perimeter: {s.CalcArea()}\n");
            }
        }
    }
}
