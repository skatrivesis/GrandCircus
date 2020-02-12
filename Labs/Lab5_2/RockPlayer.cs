using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    class RockPlayer : Player
    {
        public RockPlayer(string name) : base(name)
        {
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
