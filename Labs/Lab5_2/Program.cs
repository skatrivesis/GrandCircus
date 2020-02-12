using System;
using System.Collections.Generic;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            Roshambo humanPick;
            Roshambo computerPick;

            List<Player> players = new List<Player>();

            players.Add(new HumanPlayer(StrInput("Please input your name >> ")));

            players.Add(new RockPlayer("Steve"));
            players.Add(new FairPlayer("Bob"));

            input = IntInput($"Select an opponent: One is a fair fight and the other is dumb as a...\n1. {players[1].Name} 2. {players[2].Name} >> ");

            do
            {
                humanPick = players[0].GenerateRoshambo();
                computerPick = players[input].GenerateRoshambo();

                Console.WriteLine($"{players[0].Name} picked: {humanPick}\n{players[input].Name} picked: {computerPick}");

                if (computerPick == humanPick)
                {
                    Console.WriteLine("Congrats its a tie!");
                }
                else if (computerPick == Roshambo.Rock && humanPick == Roshambo.Paper)
                {
                    HumanWin(players[0].Name);
                }
                else if (computerPick == Roshambo.Rock && humanPick == Roshambo.Scissors)
                {
                    ComputerWin(players[input].Name);
                }
                else if (computerPick == Roshambo.Paper && humanPick == Roshambo.Scissors)
                {
                    HumanWin(players[0].Name);
                }
                else if (computerPick == Roshambo.Paper && humanPick == Roshambo.Rock)
                {
                    ComputerWin(players[input].Name);
                }
                else if (computerPick == Roshambo.Scissors && humanPick == Roshambo.Rock)
                {
                    HumanWin(players[0].Name);
                }
                else if (computerPick == Roshambo.Scissors && humanPick == Roshambo.Paper)
                {
                    ComputerWin(players[input].Name);
                }
            } while (ContinueProgram());
        }

        private static void ComputerWin(string name)
        {
            Console.WriteLine($"{name} wins!!");
        }

        private static void HumanWin(string name)
        {
            Console.WriteLine($"Congrats {name}, you win!");
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

        public static int IntInput(string text)
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

        private static string StrInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
    }
}
