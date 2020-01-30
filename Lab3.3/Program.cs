
using System;
using System.Collections.Generic;

namespace Lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, revWord;

            word = StrInput("Please input a word to be reversed: ");

            revWord = ReverseString(word);

            Console.WriteLine("Your reveresed string is " + revWord);
        }

        private static string ReverseString(string word)
        {
            //new stack
            Stack<char> stack = new Stack<char>();

            //new char arr
            char[] letters = new char[word.Length];

            //assigning string to char array
            letters = word.ToCharArray();

            //new string array
            char[] revWord = new char[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                stack.Push(letters[i]);
            }

            for (int i = 0; i < letters.Length; i++)
            {
                revWord[i] = stack.Pop();
            }

            //assigns char array to string variable
            word = new string(revWord);

            return word;
        }
        private static string StrInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

    }
}

