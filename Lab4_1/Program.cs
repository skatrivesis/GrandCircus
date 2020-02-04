using System;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int die1, die2;

            int size = IntInput("Dice size >> ");

            do
            {
                die1 = RollDice(size);
                die2 = RollDice(size);

                DisplayResults(die1, die2, size);

            } while (ContinueProgram());
        }

        static void DisplayResults(int die1, int die2, int size)
        {
            int total = die1 + die2;

            Console.WriteLine();
            if (size == 6)
            {
                if (die1 == 1 && die2 == 1)
                {
                    Console.WriteLine($"Roll 1: {die1}\nRoll 2: {die2}\nTotal: {total}\n\nSnake Eyes!\nCraps!");
                }
                else if ((die1 == 1 && die2 == 2) || (die1 == 2 && die2 == 1))
                {
                    Console.WriteLine($"Roll 1: {die1}\nRoll 2: {die2}\nTotal: {total}\n\nAce Deuce!\nCraps!");
                }
                else if (die1 == 6 && die2 == 6)
                {
                    Console.WriteLine($"Roll 1: {die1}\nRoll 2: {die2}\nTotal: {total}\n\nBox Cars!\nCraps!");
                }
                else
                {
                    Console.WriteLine($"Roll 1: {die1}\nRoll 2: {die2}\nTotal: {total}");
                }
                if (total == 7 || total == 11)
                {
                    Console.WriteLine($"\nYou Win!");
                }
                Console.WriteLine();
            }
        }
        static int RollDice(int size)
        {
            var rand = new Random();

            return rand.Next(1, size + 1);
        }

        static int IntInput(string text)
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
        static bool ContinueProgram()
        {
            char c;
            do
            {
                Console.Write("Would you like to roll again? (y/n): ");
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
