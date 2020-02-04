using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, large, small, product;
            double power;
            Console.Write("Num 1 >> ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Num2 >> ");
            num2 = int.Parse(Console.ReadLine());


            large = ReturnLarge(num1, num2);

            small = ReturnSmall(num1, num2);

            product = ReturnProduct(num1, num2, out power);

            Console.WriteLine("Larger number = " + large);
            Console.WriteLine("Smaller number = " + small);
            Console.WriteLine($"Product of {num1} and {num2} = {product}");
            Console.WriteLine($"Power of {num1} and {num2} = {power}");
        }

        private static int ReturnProduct(int num1, int num2, out double power)
        {
            power = Math.Pow(num1, num2);
            return num1 * num2;
        }

        private static int ReturnSmall(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        private static int ReturnLarge(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
