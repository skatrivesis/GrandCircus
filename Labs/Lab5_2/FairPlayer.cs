using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class FairPlayer : Player
    {
        public FairPlayer(string name) : base(name)
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            
            return (Roshambo)random.Next(0,3);
        }
    }
}
