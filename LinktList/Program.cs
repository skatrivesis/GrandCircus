using System;
using System.Collections.Generic;

namespace LinktList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> pokedex = new LinkedList<string>();
            string pokemon;

            Console.WriteLine("Welcome to the National DEX(lite)!!");

            do
            {
                Console.Write("Please enter a Pokemon or -1 to end: ");
                pokemon = Console.ReadLine();

                if (pokemon != "-1")
                {
                    pokedex.AddLast(pokemon);
                }

            } while (pokemon != "-1");

            while (pokedex.Contains("Charizard"))
            {
                pokedex.Remove("Charizard");
            }

            foreach (string pkm in pokedex)
            {
                Console.WriteLine(pkm);
            }

        }
    }
}
