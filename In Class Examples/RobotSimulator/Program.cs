using System;
using System.Collections.Generic;

namespace RobotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robotList = new List<Robot>();
            robotList.Add(new WallE("Wall-E!!!"));
            robotList.Add(new WallE("Wall-F"));
            robotList.Add(new WallE("Wall-G"));
            robotList.Add(new Eve("Eve"));
            robotList.Add(new Eve("Ev-a!!!"));
            robotList.Add(new BallerBot("Ballah"));
            robotList.Add(new BallerBot("Ballin"));
            robotList.Add(new FlyBoy("F-52"));
            robotList.Add(new FlyBoy("F-35"));

            //simulation loop
            while (true)
            {
                foreach(Robot r in robotList)
                {
                    r.Act();
                    Console.WriteLine(r);
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
