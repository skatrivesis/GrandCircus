using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2
{
    abstract class Player
    {
        protected string name;
        protected Roshambo roshamboVal;

        protected Player(string name)
        {
            this.name = name;
        }

        public string Name { get => name; }
        public Roshambo RoshamboVal { get => roshamboVal; set => roshamboVal = value; }

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
