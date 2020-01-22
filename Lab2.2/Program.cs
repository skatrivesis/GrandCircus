using System;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            bool flag;

            Console.WriteLine("\n{{Insert Welcome message here}}");

            do
            {
                input = IntegerInput("\nPlease input a postive whole number: ");

                DisplayGrid(input);

                flag = RunAgain();

            } while (flag);

            Console.WriteLine("\nThank you have a great day!!");
        }

        private static bool RunAgain()
        {
            int x;

            x = IntegerInput("\nPlease input -999 to exit program, or any other number to try again: ");

            if (x == -999)
            {
                return false;
            } 
            else
            {
                return true;
            }
        }

        private static void DisplayGrid(int input)
        {
            Header();

            for (int i = 1; i <= input; i++)
            {
                Console.Write(i + "\t");
                Console.Write(CalculateSquare(i) + "\t");
                Console.Write(CalculateCube(i) + "\t");
                Console.WriteLine();
            }
        }

        private static void Header()
        {
            Console.WriteLine("\nNumber\tSquared\tCubed");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                Console.Write("=");
                }
                Console.Write("\t");
            }
            Console.WriteLine();
        }

        private static int CalculateCube(int input)
        {
            return (int)Math.Pow(input, 3);
        }

        private static int CalculateSquare(int input)
        {
            return (int)Math.Pow(input, 2);
        }

        private static int IntegerInput(string text)
        {
            Console.Write($"{text}");
            string s = Console.ReadLine();
            bool worked = int.TryParse(s, out int x);

            while (!worked)
            {
                Console.Write($"**Input not accepted**\n{text}");
                s = Console.ReadLine();
                worked = int.TryParse(s, out x);
            }
            return x;
        }
    }
}
