using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSimulator
{
    class BallerBot : Robot
    {
        public BallerBot(string name) : base(name)
        {
            speed = 20;
            energy = 8;
            GenerateLocation(out x, out y);
            z = 0;
        }

        public override void Act()
        {
            if (energy < 1.0)
            {
                Charge(.5);
            }
            //pretend I'm deciding if he moves or compacts
            else if (true)
            {
                Move();
            } 
            else
            {
                BallOut();
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

            energy -= .1;
        }

        public void BallOut()
        {
            //compact
            energy -= 1;
        }
    }
}
