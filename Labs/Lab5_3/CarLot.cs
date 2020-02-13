using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_3
{
    class CarLot
    {
        int idCount = 0;
        int targetId;
        bool used;
        string makeName;
        string modelName;
        int year;
        double price;
        double milage;

        List<Car> cars = new List<Car>();

        public void AddCar()
        {
            used = BinaryChoice("Is the car (n)ew or (u)sed? ");

            makeName = StrInput("\nEnter Make >> ");
            modelName = StrInput("Enter Model >> ");
            year = IntInput("Enter Year >> ");
            price = DoubleInput("Enter Price >> ");

            if (used)
            {
                milage = DoubleInput("Enter Mileage >> ");
                cars.Add(new UsedCar(idCount, makeName, modelName, year, price, milage));
                idCount++;
            }
            else
            {
                cars.Add(new Car(idCount, makeName, modelName, year, price));
                idCount++;
            }
        }
        public void InitializeInventory()
        {
            cars.Add(new Car(idCount, "Chevy", "Silverado", 2014, 24000));
            idCount++;
            cars.Add(new Car(idCount, "Chevy", "Cruze", 2012, 20000));
            idCount++;
            cars.Add(new UsedCar(idCount, "Dodge", "Ram", 2009, 16000, 200000));
            idCount++;
            cars.Add(new Car(idCount, "Honda", "Accord", 2029, 9999999.99));
            idCount++;
        }
        public void DisplayCars()
        {
            Console.WriteLine($"{"Id",-5}|{"Make",-15}|{"Model",-15}|{"Year",-5}|{"Price",-15}|(Used) {"Mileage",-21}|");
            for (int i = 0; i < 90; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }
        }

        public void RemoveCar()
        {
            int[] carIds = new int[cars.Count];

            targetId = IntInput("Which car would you like to buy? >> ");

            for (int i = 0; i < cars.Count; i++)
            {
                carIds[i] = cars[i].Id;
            }

            for (int i = 0; i <= carIds.Length; i++)
            {
                if (cars[i].Id == targetId)
                {
                    Console.WriteLine($"Congrats on your new/used {cars[i].Make} {cars[i].Model}\nYou probably bought this sucker for wayyyy to much money, you spent {cars[i].Price.ToString("c")} on this bad boy.");
                    cars.Remove(cars[i]);
                    break;
                }
            }
        }

        public string StrInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
        public int IntInput(string text)
        {
            Console.Write($"{text}");
            string s = Console.ReadLine();
            bool worked = int.TryParse(s, out int x);

            while (!worked)
            {
                Console.Write($"\n**Input not accepted**\n{text}");
                s = Console.ReadLine();
                worked = int.TryParse(s, out x);
            }
            return x;
        }
        public double DoubleInput(string text)
        {
            Console.Write($"{text}");
            string s = Console.ReadLine();
            bool worked = double.TryParse(s, out double x);

            while (!worked)
            {
                Console.Write($"\n**Input not accepted**\n{text}");
                s = Console.ReadLine();
                worked = double.TryParse(s, out x);
            }
            return x;
        }
        public bool BinaryChoice(string text)
        {
            char c;
            do
            {
                Console.Write(text);
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    return false;
                }
                Console.WriteLine();
            } while (c != 'u' && c != 'U');

            return true;
        }
    }
}
