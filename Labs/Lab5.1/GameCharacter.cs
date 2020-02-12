using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_1
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;

        public GameCharacter(string name, int strength, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
        }

        public string Name { get => name; set => name = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }

        public virtual string Play()
        {
            return $"{"\nName: ",-20}{name}\n{"Strength: ",-20}{strength}\n{"Intelligence: ",-20}{intelligence}";
        }
    }
}
