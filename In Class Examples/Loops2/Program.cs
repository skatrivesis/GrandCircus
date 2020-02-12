using System;

namespace Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Prints numbers 2-100 and prints the factors of each using a nested loop
            //for (int i = 1; i <= 100 ; i++)
            //{
            //    Console.Write($"Factors of {i}: ");
            //    for (int j = 2; j <= i/2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            Console.Write(j + " ");
            //        }
            //    }
            //    Console.WriteLine(i); //number will always be a factor of itself so this will print out the number at the end
            //}

            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            bool worked = int.TryParse(input, out int a);
            
            while (!worked || a < 0)
            {
                Console.WriteLine("That wasn't a valid number! Please input a positive integer: ");
                input = Console.ReadLine();
                worked = int.TryParse(input, out a);
            }

            Console.Write("Please enter a number that you would like to decrement by: ");
            input = Console.ReadLine();
            worked = int.TryParse(input, out int b);

            while (!worked || a < 0)
            {
                Console.WriteLine("That wasn't a valid number! Please input a positive integer to decrement by: ");
                input = Console.ReadLine();
                worked = int.TryParse(input, out b);
            }

            for (int i = a; i >= 0; i -= b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
