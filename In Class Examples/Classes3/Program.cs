using System;
using System.Collections.Generic;

namespace Classes3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact> ();

            contacts.Add(new Contact("Katrivesis", "Socrates", "2486350885", "skatrivesis@gmail.com"));
            contacts.Add(new Contact("Beeve", "Steve", "24865", "skats@gmail.com"));
            contacts.Add(new Contact("B", "F", "24485", "f@gmail.com"));
            contacts.Add(new Contact("S", "A", "20885", "sfs@gmail.com"));

            contacts[3].Email = "Beeve";

            foreach (Contact c in contacts)
            {
                Console.WriteLine(c);
            }

            Console.Write("Please enter last name to search for: ");
            string input = Console.ReadLine();

            foreach (Contact c in contacts)
            {
                if (c.LastName.Contains(input))
                {
                    Console.WriteLine(c.LastName);
                }
            }
        }
    }
}
