namespace Classes1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating a circle
            //this calls the constructor
            Circle circle1 = new Circle(9.0);
            Circle circle2 = new Circle();

            circle2.Radius = 3;//this is using the property to set

            //System.Console.WriteLine($"Circle1 Radius: {circle1.Radius} Circumference: {circle1.CalcCircumference()} Area: {circle1.CalcArea()}");
            //System.Console.WriteLine($"Circle2 Radius: {circle2.Radius} Circumference: {circle2.CalcCircumference()} Area: {circle2.CalcArea()}");

            System.Console.WriteLine("Circle1: " + circle1);
            System.Console.WriteLine("Circle2: " + circle2);
        }
    }
}
