using System;

namespace Lab5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            bool flag = true;
            CarLot lot = new CarLot();
            lot.InitializeInventory();
            do
            {
                Console.WriteLine("Welcome to Soc and Marks used car lot!!\nWhere the deals are bad and we love $$$$$$$$!!\n");

                input = lot.IntInput("1. Add Car\n2. Display Cars\n3. Sell Car\n4. Clear Console\n5. Quit\n >> ");
                Console.WriteLine();
                switch (input)
                {
                    case 1:
                        lot.AddCar();
                        break;
                    case 2:
                        lot.DisplayCars();
                        break;
                    case 3:
                        lot.RemoveCar();
                        break;
                    case 4:
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Have a good day!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("That input does not exist. Please input a correct menu input >> ");
                        break;
                }
                Console.WriteLine();
            } while (flag);
        }
    }
}
