using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSimulator
{
    class FlyBoy : Robot
    {
        public FlyBoy(string name) : base(name)
        {
            speed = 25;
            energy = 80;
            GenerateLocation(out x, out y, out z);
        }

        public override void Act()
        {
            if (energy < 1.0)
            {
                Charge(.10);
            }
            //pretend I'm deciding if he moves or compacts
            else if (true)
            {
                Move();
            } 
            else
            {
                DropBombs();
            }
        }

        public override void Move()
        {
            int dir = random.Next(0, 4);
            
            if (dir == 0)
            {
                y -= speed;
            } 
            else if (dir == 1)
            {
                x += speed;
            }
            else if (dir == 2)
            {
                y += speed;
            }
            else
            {
                x -= speed;
            }

            int altChange = random.Next(0, 3);
            if (altChange == 1)
            {
                z++;
            }
            else if (altChange == 2)
            {
                if (z > 0)
                {
                    z--;
                }
            }
            energy -= .7;
        }

        public void DropBombs()
        {
            //compact
            energy -= 10;
        }
    }
}
