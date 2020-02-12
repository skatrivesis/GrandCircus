using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            int input = Program.IntInput("Input 1 for Rock 2 for Paper 3 for Scissors >> ");

            while (input < 1 || input > 3)
            {
                Console.WriteLine("\n**Input not accepted**\n");
                input = Program.IntInput("Input 1. for Rock 2. for Paper 3. for Scissors >> ");
            }

            return (Roshambo)input - 1;
        }
    }
}
