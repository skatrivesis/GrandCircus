using System;
using System.Text.RegularExpressions;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Try to figure these out without looking up others’ solutions!

            //4.Write a method that will validate phone numbers.A phone number should be in the
            //    following format: { area code of 3 digits} – { 3digits} – { 4 digits}
            //such as 313 - 555 - 1212

            //5.Write a method that will validate date based on the following format: (dd / mm / yyyy).

            bool flag;
            string name;
            string email;
            string phoneNumber;

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

            PrintOutput(name, email, phoneNumber);

        } //end main

        private static void PrintOutput(string name, string email, string phoneNumber)
        {
            Console.WriteLine("Here is your information!");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
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
