using System;

namespace Exercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max, num;
            char key;
            //input two numbers
            //upper and lower range
            // enter another number and check to see if it lies in range

            //TODO: Validate user data here
            Console.Write("Please enter the lower number of the range: ");
            int.TryParse(Console.ReadLine(), out min);

            Console.Write("Please enter the higher number of the range: ");
            int.TryParse(Console.ReadLine(), out max);

            do
            {
                Console.Write("Please enter number to check: ");
                int.TryParse(Console.ReadLine(), out num);

                //check & notify if it's greater than the larger number
                //check & notify if it's less than the smaller number
                //let the user know if it's in range
                if (num > max)
                {
                    Console.WriteLine("Number is higher than range");
                }
                else if (num < min)
                {
                    Console.WriteLine("Number is lower than range");
                }
                else
                {
                    Console.WriteLine("Number is within the range.");
                }

                Console.Write("Would you like to test another number (y/n)");
                key = Console.ReadKey().ToString().ToLower()[0];

                while (key != 'y' && key != 'n')
                {
                    Console.WriteLine("Invalid input. Please press y or n: ");
                    key = Console.ReadKey().KeyChar;
                }

                Console.WriteLine();
            } while (key != 'n');

            Console.WriteLine("Thank you, Come Again!"); ;
        }
    }
}
