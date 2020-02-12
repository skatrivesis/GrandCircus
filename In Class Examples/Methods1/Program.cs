using System;
using System.Collections.Generic;
using System.Text;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;

            Console.WriteLine("Welcome to the string reverser!");
            text = GetText();

            Console.WriteLine(ReverseWord(text));

        }
        private static string GetText()
        {
            return GetText("Enter text: ");
        }

        private static string GetText(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static string GetText(string prompt, int minLength)
        {
            string text;
            do
            {
                text = GetText(prompt);
            }
            while (text.Length < minLength);

            return text;
        }

        //static void ReverseWord(string text)
        //{
        //    Stack<char> stack = new Stack<char>();

        //    foreach (char c in text)
        //    {
        //        stack.Push(c);
        //    }

        //    while (stack.Count > 0)
        //    {
        //        Console.Write(stack.Pop());
        //    }
        //}
        static string ReverseWord(string text)
        {
            StringBuilder reversed = new StringBuilder();

            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                stack.Push(c);
            }

            while (stack.Count > 0)
            {
                reversed.Append(stack.Pop());
            }

            return reversed.ToString();
        }
    }
}
