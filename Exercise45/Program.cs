
using System;
using System.Collections.Generic;

namespace Exercise45
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareNum = 0;
            double side;

            List<Square> squares = new List<Square>();

            do
            {
                side = DoubleInput("Enter a side length >> ");

                squares.Add(new Square(side));

                DisplaySquare(squares, squareNum);

                squareNum++;

            } while (ContinueProgram());

            PrintAllSquares(squares);

        }

        private static void PrintAllSquares(List<Square> squares)
        {
            Console.WriteLine("\n\nHere are all the squares you entered... you square...:");
            for (int i = 0; i < squares.Count; i++)
            {
                Console.WriteLine($"Square {i + 1}: {squares[i]}");
            }
        }

        private static void DisplaySquare(List<Square> squares, int squareNum)
        {
            Console.WriteLine(squares[squareNum]);
        }

        private static double DoubleInput(string text)
        {
            Console.Write($"{text}");
            string s = Console.ReadLine();
            bool worked = double.TryParse(s, out double x);

            while (!worked)
            {
                Console.Write($"\n**Input not accepted**\n{text}");
                s = Console.ReadLine();
                worked = double.TryParse(s, out x);
            }
            return x;
        }
        static bool ContinueProgram()
        {
            char c;
            do
            {
                Console.Write("Would you like to continue (y/n): ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    return false;
                }
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');

            return true;
        }

    }
}
