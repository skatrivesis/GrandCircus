using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Circle : Shape
    {

        private double radius;

        public double Radius { get => radius; set => radius = value; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalcPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override double CalcArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
