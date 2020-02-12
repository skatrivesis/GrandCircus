using System;
using System.Text.RegularExpressions;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag;
            string name;
            string email;
            string phoneNumber;
            string birthday;

            Console.WriteLine("Hello and Welcome!!");

            string input = GetStringInput("Enter a first name: ");

            do
            {
                flag = ValidateName(input);

                if (!flag)
                {
                    input = GetStringInput("Input not correct.\n" +
                    "Please input a first name with only letters and make sure the first is capitalized: ");
                }
                else
                {
                Console.WriteLine("Thank you for your input!");
                }
                name = input;
            } while (!flag);

            input = GetStringInput("Please enter your email address: ");

            do
            {
                flag = ValidateEmail(input);

                if (!flag)
                {
                    input = GetStringInput("Input not correct.\n" +
                    "Please input a valid email address: ");
                }
                else
                {
                    Console.WriteLine("Thank you for your input!");
                }
                email = input;
            } while (!flag);

            input = GetStringInput("Please enter your phone number: ");

            do
            {
                flag = ValidatePhoneNumber(input);

                if (!flag)
                {
                    input = GetStringInput("Input not correct.\n" +
                    "Please input a valid phone number: ");
                }
                else
                {
                    Console.WriteLine("Thank you for your input!");
                }
                phoneNumber = input;
            } while (!flag);

            input = GetStringInput("Please enter your birthday in the following format [mm\\dd\\yyy]: ");

            do
            {
                flag = ValidateDate(input);

                if (!flag)
                {
                    input = GetStringInput("Input not correct. Please use the following format [mm\\dd\\yyy]: ");
                }
                else
                {
                    Console.WriteLine("Thank you for your input!");
                }
                birthday = input;
            } while (!flag);

            PrintOutput(name, email, phoneNumber, birthday);

        } //end main
        private static void PrintOutput(string name, string email, string phoneNumber, string birthday)
        {
            Console.WriteLine("Here is your information!");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"Birthday: {birthday}");
        }

        private static bool ValidateDate(string x)
        {
            string pattern = @"^\d{2}\/\d{2}\/\d{4}$";

            if (Regex.IsMatch(x, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidatePhoneNumber(string x)
        {
            string pattern = @"^\d{3}(\s?-?\s?)\d{3}(\s?-?\s?)\d{4}$";

            if (Regex.IsMatch(x, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string GetStringInput(string text)
        {
            Console.Write(text);
            string x = Console.ReadLine();

            return x;
        }

        private static bool ValidateEmail(string x)
        {
            string pattern = @"^([A-z]{5,30}\@)[A-z]{5,10}(\.\w{2,3})$";

            if (Regex.IsMatch(x, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidateName(string x)
        {
            string pattern = @"^[A-Z]{1}[A-z'-]{1,29}$";

            if (Regex.IsMatch(x, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
