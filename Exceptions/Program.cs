using System;
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool worked = false;
            int n = 0;
            int answer = 0;
            do
            {
                Console.Write("Please enter a number: ");
                worked = int.TryParse(Console.ReadLine(), out n);
                if (!worked)
                {
                    Console.WriteLine("Sorry, please try again.");
                }
            } while (!worked);
            //try as few lines of code as possible--just where you know
            // exceptions can happen
            //whenever possible, prevent the exception rather than catching it
            try
            {
                answer = DoMath(n);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Whoops. Guess I used too big a number");
                return;//nothing else to do--get out
            }
            catch (Exception e)
            {
                Console.WriteLine("Can't use 0");
                return;
            }
            Console.WriteLine("The answer is " + answer);
        }
        //preconditions: things that are expected to be true before the method runs
        //preconditions should be tested in your code
        // n cannot be 0 or negative
        // n cannot be more than 10
        static int DoMath(int n)
        {
            if (n <= 0)
            {
                //this should be an ArgumentException too
                throw new Exception("You're an idiot");
            }
            else if (n > 10)
            {
                throw new ArgumentException("DoMath only works up to 10");
            }
            return 10 / n;
        }
    }
}