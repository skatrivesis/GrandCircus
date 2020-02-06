using System;
using System.Collections.Generic;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            string input;
            List<Movie> movies = new List<Movie>();

            movies.Add(new Movie("Die Hard", "Christmas"));
            movies.Add(new Movie("Harry Potter 1", "Christmas"));
            movies.Add(new Movie("Avatar", "Animated"));
            movies.Add(new Movie("Peter Pan", "Animated"));
            movies.Add(new Movie("Drive", "Drama"));
            movies.Add(new Movie("The Matrix", "Scifi"));
            movies.Add(new Movie("John Carpenters: The Thing!", "Horror"));
            movies.Add(new Movie("The Grudge", "Horror"));
            movies.Add(new Movie("Fast and Furious", "Drama"));
            movies.Add(new Movie("Star Wars", "Scifi"));

            do
            {
                input = DisplayCategories(movies).ToLower();

                flag = CategoryExist(input, movies);

                ResultCategories(flag, input, movies);

            } while (ContinueProgram());
        }

        private static string DisplayCategories(List<Movie> movies)
        {
            int selection;
            List<string> categories = new List<string>();

            foreach (Movie m in movies)
            {
                if (!categories.Contains(m.Category))
                {
                    categories.Add(m.Category);
                }
            }

            Console.WriteLine("Categories\n=========================");

            for (int i = 0; i < categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {categories[i]}");
            }

            do
            {
                selection = IntInput("Input category number: ");
                if (selection > categories.Count || selection < 0)
                {
                    Console.WriteLine("\nInput invalid, please try again.\n");
                }
            } while (selection > categories.Count || selection < 0);

            return categories[selection - 1];
        }

        private static void ResultCategories(bool flag, string input, List<Movie> movies)
        {
            Console.WriteLine();
            if (flag)
            {
                foreach (Movie m in movies)
                {
                    if (m.Category.ToLower().Contains(input))
                    {
                        Console.WriteLine(m);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nSorry, that category does not exist within the list.\n");
            }
            Console.WriteLine();
        }
        private static bool CategoryExist(string input, List<Movie> movies)
        {
            bool flag = false;

            foreach (Movie m in movies)
            {
                if (m.Category.ToLower().Contains(input))
                {
                    flag = true;
                }
            }
            return flag;
        }
        static bool ContinueProgram()
        {
            char c;
            do
            {
                Console.Write("Would you like to search again? (y/n): ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    return false;
                }
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');

            return true;
        }
        private static int IntInput(string text)
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
    }
}
