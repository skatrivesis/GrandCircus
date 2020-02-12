using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    abstract class Quadrilateral : Shape
    {
        private double b;
        private double h;

        //do not need a constructor because it will never be instantiated

        public double B { get => b; set => b = value; }
        public double H { get => h; set => h = value; }
    }
}
