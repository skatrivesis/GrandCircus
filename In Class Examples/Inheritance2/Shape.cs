using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    abstract class Shape //abstract needs to be put here if we have abstract methods
    {
        public abstract double CalcArea(); //as long as this is abstract it does not need a body. We are doing this because you cannot have a default shape

        public abstract double CalcPerimeter();

        //abstract class may have concrete (implemented) methods
        //and it can even call on methods that aren't implemented yet
        public override string ToString()
        {
            return $"Perimeter: {CalcPerimeter()}\t\tArea: {CalcArea()}";
        }
    }
}
