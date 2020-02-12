using System;

namespace Enums1
{
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Wednesday;
            Days tomorrow = today + 1;

            Months month = Months.February;
            Months nextMonth = (Months)3;
            Console.WriteLine($"Today is a {today} in {month}");
            Console.WriteLine($"Tomorrow is a {tomorrow}");
            Console.WriteLine($"Next month is {nextMonth}");
        }
    }
}
