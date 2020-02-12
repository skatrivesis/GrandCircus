using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Char ltrGrade = ' ';

            Console.WriteLine("Welcome to the GradeBook!");

            while (true)
            {
                Console.Write("Please enter percentage grade: "); //Makes the cursor on the same line of the console

                string input = Console.ReadLine();
                double pctGrade = double.Parse(input); //assigns string to pctGrade variable as a double data type

                if (pctGrade >= 90)
                {
                    ltrGrade = 'A';
                }
                else if (pctGrade >= 80)
                {
                    ltrGrade = 'B';
                }
                else if (pctGrade >= 70)
                {
                    ltrGrade = 'C';
                }
                else if (pctGrade >= 60)
                {
                    ltrGrade = 'D';
                }
                else
                {
                    ltrGrade = 'F';
                }

                Console.WriteLine(pctGrade + " is a(n) " + ltrGrade);
            }
        }
    }
}
