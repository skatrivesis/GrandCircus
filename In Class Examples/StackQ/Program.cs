using System;
using System.Collections.Generic;

namespace StackQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string word;


            Console.WriteLine("Welcome to the Word Stack/Queue");


            do
            {
                Console.Write("Please enter a word or -1 to end: ");
                word = Console.ReadLine();

                if (word != "-1")
                {
                    stack.Push(word);

                }

            } while (word != "-1");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Queue<string> q = new Queue<string>();

            Console.WriteLine("Queue");

            do
            {
                Console.Write("Please enter a word or -1 to end: ");
                word = Console.ReadLine();

                if (word != "-1")
                {
                    q.Enqueue(word);

                }

            } while (word != "-1");

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }


            Console.WriteLine("Goodbye");
            
        }
    }
}
