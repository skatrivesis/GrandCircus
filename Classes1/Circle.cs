using System;
using System.Collections.Generic;
using System.Text;

namespace Classes1
{
    class Circle
    {
        //data members, variables that belong to the instance
        //instance variable -- each instance has its own variables
        #region fields 
        private double radius;
        #endregion

        //Property can give public access to a private field
        #region properties
        public double Radius // << cap
        {
            get { return radius; } // << not cap // << provides read access
            set { radius = value; } // << provides write access //value is a keyword
        }
        #endregion properties


        #region constructors
        //a constructor is called when you use the new keyword
        //generally public, never static, NO return type (not void)
        public Circle()
        {
            radius = 0;
        }

        public Circle(double _radius) //overloaded method
        {
            radius = _radius;
            //this.radius = radius;
        }
        #endregion constructors


        #region methods
        //methods are behaviors--they're actions taken on the data in the class
        public double CalcCircumference()
        {
            return radius * 2 * Math.PI;
        }

        public double CalcArea()
        {
            return radius * radius * Math.PI;
        }
        #endregion methods
        
        public override string ToString() //when writing a ToString, its always going to look like this
        {
            return $"Circle1 Radius: {Radius:F2} Circumference: {CalcCircumference():F2} Area: {CalcArea():N2}";
        }




        //public void setRadius (double r)
        //{
        //    radius = new decimal(r);
        //}

        //public double getRadius()
        //{
        //    return (double)radius;
        //}
    }
}
