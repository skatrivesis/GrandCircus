using System;
using System.Collections.Generic;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Warrior("Stavin Braskit", 3, 5, "Bow"));
            gameCharacters.Add(new Wizard("Lavin Dasbrit", 1, 39, 27, 4));
            gameCharacters.Add(new Warrior("Bravin Staskit", 10, 3, "Sword"));
            gameCharacters.Add(new Wizard("Cravin Raspit", 15, 2, 20, 1));
            gameCharacters.Add(new Wizard("Braken Fastkit", 2, 25, 15, 2));

            Console.WriteLine("Welcome to magic land... -_-");

            foreach (GameCharacter character in gameCharacters)
            {
                Console.WriteLine(character.Play());
            }
        }
    }
}
