using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy)
            : base(name, strength, intelligence)
        {
            this.magicalEnergy = magicalEnergy;
        }

        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public override string Play()
        {
            return base.Play() + $"\n{"Magic: ",-20}{magicalEnergy}";
        }
    }
}
