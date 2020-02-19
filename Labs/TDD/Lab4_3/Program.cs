using System;

namespace Lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int index, menu, prime;

            do
            {
                menu = IntInput("1. Give index and recieve prime.\n2. Give prime and recieve index.\n(Input a number lower than 1 to quit) >> ");
                switch (menu)
                {
                    case 1:
                        index = IntInput("Enter a prime index to see prime >> ");
                        prime = PrimeNumbers.GeneratePRime(index);
                        Console.WriteLine($"Index: {index} Prime: {prime}\n");
                        break;
                    case 2:
                        prime = IntInput("Enter a prime number and see its index >> ");
                        if (PrimeNumbers.CheckPrime(prime))
                        {
                            index = PrimeNumbers.PrimeIndex(prime);
                            Console.WriteLine($"Prime: {prime} Index: {index}\n");
                        }
                        else
                        {
                            Console.WriteLine("That is not a prime number, please try again!\n");
                        }
                        break;
                    default:
                        break;
                }
            } while (menu > 0);
        }

        //Get an Int Input
        private static int IntInput(string text)
        {
            Console.Write($"{text}");
            string s = Console.ReadLine();
            bool worked = int.TryParse(s, out int x);

            while (!worked)
            {
                Console.Write($"\n**Input not accepted**\n{text}");
                s = Console.ReadLine();
                worked = int.TryParse(s, out x);
            }
            return x;
        }
    }
}
