using System;

namespace Lab4_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int location;
            string word;

            do
            {
                word = StrInput("Word: ").ToLower();

                location = FindVowelLocation(word);

                if (location == -1)
                {
                    Console.WriteLine("There are no vowels in your word!!");
                }
                else
                {
                    Console.WriteLine(PigLatinize(word, location));
                }
            } while (ContinueProgram());
        }

        private static int FindVowelLocation(string word)
        {
            int location = -1;
            bool flag = true;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        flag = !flag;
                        location = i;
                        break;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }
            return location;
        }

        private static string PigLatinize(string word, int location)
        {
            if (location == 0)
            {
                return word += "way";
            }
            else
            {
                word += word.Substring(0, location) + "ay";
                return word.Remove(0, location);
            }
        }

        private static string StrInput(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }
        static bool ContinueProgram()
        {
            char c;
            do
            {
                Console.Write("Would you like to input another word? (y/n): ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    return false;
                }
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');

            return true;
        }

    }
}
