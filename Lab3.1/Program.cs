using System;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Students are Pokemon
            //Job titles are Moves
            //Candy is Candy... because even pokemon like candy

            string[] pokemon = { "Ampharos", "Basculin", "Chimchar", "Duraladon", "Escavalier", "Feraligator", "Grubbin", "Heracross", "Ivysaur", "Jigglypuff" };
            string[] moves = { "Amnesia", "Bubblebeam", "Charm", "Dig", "Ember", "Feint", "Giga Drain", "Hex", "Ice Beam", "Jump Kick" };
            string[] candy = { "Air Heads", "Butterfinger", "Chocolate", "Dots", "Extra Gum", "Fun Dip", "Gummi Bears", "Hot Tamales",  "Ice Breakers", "Jawbreaker" };

            bool flag;
            int statInput;
            int pkmnSel;

            do
            {
                DisplayStudents(pokemon, moves, candy);

                pkmnSel = IntInput("Please enter a number for the Pokemon you wish to look into: ");

                while (pkmnSel > pokemon.Length || pkmnSel <= 0)
                {
                pkmnSel = IntInput("That number is not assigned to a pokemon. Please enter a number for the Pokemon you wish to look into: ");
                }

                statInput = IntInput("What would you like to know about this Pokemon? 1. for (Favorite move) | 2. for (Favorite candy) : ");

                while (statInput != 1 && statInput != 2)
                {
                    statInput = IntInput("\nNot a valid entry, please input a valid entry.\nWhat would you like to know about this Pokemon? 1. for (Favorite move) | 2. for (Favorite candy) : ");
                }
                
                if (statInput == 1)
                {
                    Console.WriteLine($"{pokemon[pkmnSel - 1]}'s favorite move is {moves[pkmnSel - 1]}");
                }
                else if (statInput == 2)
                {
                    Console.WriteLine($"{pokemon[pkmnSel - 1]}'s favorite candy is {candy[pkmnSel - 1]}");
                } 

                flag = RunAgain();
                
            } while (flag);
        } //end main

        private static void DisplayStudents(string[] pokemon, string[] moves, string[] candy)
        {
            Console.WriteLine(String.Format("{0,15} | {1,-25} | {2,-25} | {3,-25}", "Pokemon Number", "Pokemon", "Favorite Moves", "Favorite Candy"));
            Console.WriteLine("========================================================================================================");
            for (int i = 0; i < pokemon.Length; i++)
            {
                Console.WriteLine(String.Format("{0,15} | {1,-25} | {2,-25} | {3,-25}", i + 1, pokemon[i], moves[i], candy[i]));
            }
            Console.WriteLine();
        }

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

        private static bool RunAgain()
        {
            Console.WriteLine("\nPlease [Q] to quit or any other key to try again. :\n");

            if (Console.ReadKey(true).Key == ConsoleKey.Q)
            {
                Console.WriteLine("Thank you have a good day!");
                return false;
            } 
            else
            {
                Console.WriteLine("Let us run it again!\n");
                return true;
            }
        }
    }
}
