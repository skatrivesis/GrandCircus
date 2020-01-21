using System;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input;

            double length;
            double width;
            double height;
            double area = 0;
            double perimiter = 0;
            double volume = 0;
            bool flag;

            Console.WriteLine("Welcome to the room calculator!\n");

            do
            {
                PleaseEnter("length");
                length = double.Parse(Input());

                PleaseEnter("width");
                width = double.Parse(Input());

                PleaseEnter("height");
                height = double.Parse(Input());

                CalculateStats(length, width, height, ref area, ref perimiter, ref volume);

                PrintStats(area, perimiter, volume);

                Sizer(area);

                flag = RunAgain();

            } while (flag == true);

            Console.WriteLine("\nPlease enjoy your room sizes! Thank you have a great day!!");

        }

        private static void PleaseEnter(string x)
        {
            Console.Write($"Please enter room {x}: ");
        }

        private static bool RunAgain()
        {
            int input;

            Console.Write("Would you like to calculate another room? (Please input 1 for yes and 0 for no): ");
            input = int.Parse(Input());

            if (input == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void CalculateStats(double length, double width, double height, ref double area, ref double perimiter, ref double volume)
        {
            area = CalculateArea(length, width);
            perimiter = CalculatePerimiter(length, width);
            volume = CalculateVolume(length, width, height);
        }

        private static void PrintStats(double area, double perimiter, double volume)
        {
            Console.WriteLine($"Area of the room is: {area}");
            Console.WriteLine($"Perimiter of the room is : {perimiter}");
            Console.WriteLine($"Volume of the room is: {volume}");
        }

        static string Input()
        {
            return Console.ReadLine();
        }

        static double CalculateVolume(double length, double width, double height)
        {
            return length * width * height;
        }

        static double CalculatePerimiter(double length, double width)
        {
            return (2 * length) + (2 * width);
        }
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        private static void Sizer(double area)
        {
            string size;

            if (area <= 250)
            {
                size = "Small";
            }
            else if (area > 250 && area < 650)
            {
                size = "Medium";
            }
            else
            {
                size = "Large";
            }

            Console.WriteLine($"This is a {size} room.");
        }
    }
}
