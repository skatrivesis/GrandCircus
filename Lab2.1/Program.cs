using System;

namespace Lab2._1
{
    class Program
    {
        public static void Sizer(string size, int area)
        {
            
        }
        static void Main(string[] args)
        {
            string input;

            double length;
            double width;
            double height;
            double area;
            double perimiter;
            double volume;
            bool flag = true;

            Console.WriteLine("Welcome to the room calculator!");

            do
            {
                Console.Write("\nPlease enter room Length: ");
                input = Console.ReadLine();
                length = double.Parse(input);

                Console.Write("Please enter room Width: ");
                input = Console.ReadLine();
                width = double.Parse(input);

                Console.Write("Please enter room Height: ");
                input = Console.ReadLine();
                height = double.Parse(input);

                area = CalculateArea(length, width);
                perimiter = CalculatePerimiter(length, width);
                volume = CalculateVolume(length, width, height);

                Console.WriteLine($"Area of the room is: {area}");
                Console.WriteLine($"Perimiter of the room is : {perimiter}");
                Console.WriteLine($"Volume of the room is: {volume}");

                Sizer(area);

                Console.Write("Would you like to calculate another room? (Please input 1 for yes and 0 for no): ");
                input = Console.ReadLine();

                if (int.Parse(input) == 0)
                {
                    flag = !flag;
                }

            } while (flag == true);

            Console.WriteLine("Please enjoy your room sizes! Thank you have a great day!!");

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
