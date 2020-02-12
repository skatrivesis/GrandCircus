using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSimulator
{
    abstract class Robot
    {
        protected string name;
        protected int speed;
        protected int x, y, z;
        protected double energy;

        //Protected because this exists for Robots, nothing else
        protected static Random random;

        public Robot(string name)
        {
            this.Name = name;

            //if the random number generator hasn't been created
            if (random == null)
            {
                random = new Random();
            }
        }

        public string Name { get => name; set => name = value; }
        public int Speed { get => speed; }
        public int X { get => x; }
        public int Y { get => y;  }
        public int Z { get => z; }
        public double Energy { get => energy; }

        public abstract void Act();

        public abstract void Move();

        public void Charge (double chargeAmount)
        {
            if (chargeAmount > 0)
            {
                energy += chargeAmount;
            }
        }

        protected static int GenerateLocation()
        {
            return random.Next(0, 100);
        }

        protected static void GenerateLocation(out int x, out int y)
        {
            x = random.Next(0, 100);
            y = random.Next(0, 100);
        }

        protected static void GenerateLocation(out int x, out int y, out int z)
        {
            x = random.Next(0, 100);
            y = random.Next(0, 100);
            z = random.Next(1, 10);
        }

        public override string ToString()
        {
            return $"{name} ({x},{y},{z}) Energy {energy}";
        }
    }
}
