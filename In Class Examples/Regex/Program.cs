using System;
using System.Text.RegularExpressions;

namespace RegexExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter firstname lastname: ");
                string name = Console.ReadLine();

                string pattern = @"^[A-z'-]+\s+[A-z'-]+$";

                if (Regex.IsMatch(name, pattern))
                {
                    Console.WriteLine("Name is valid");
                }
                else
                {
                    Console.WriteLine("Name invalid");
                }
            }
        }
    }
}
