using System;
using System.Collections;
using System.Collections.Generic;

namespace HashDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory["apple"] = 12;
            inventory["bananas"] = 30;
            inventory["cherry"] = 40;
            inventory["durian"] = 1;

            inventory["apple"]--;

            Console.WriteLine(inventory["apple"]);
            
            foreach (KeyValuePair<string, int> kvPair in inventory)
            {
                Console.WriteLine($"{kvPair.Key, 10} = {kvPair.Value, -20}");
            }

            Console.WriteLine(inventory.ContainsKey("apple"));
            Console.WriteLine(inventory.ContainsKey("Steve"));
            Console.WriteLine(inventory.ContainsKey("Apple"));


            //use this over a try catch, you should always validate your input instead of
            //trying to catch exceptions. We will catch exceptions when handling stuff from outside of your program
            if (inventory.ContainsKey("elderberry"))
            {
                Console.WriteLine(inventory["elderberry"]);
            }

            Console.WriteLine("Items in inventory: " + inventory.Count);

            List<string> keys = new List<string>(inventory.Keys);

            for (int i = 0; i < keys.Count; i++)
            {
                inventory[keys[i]] += 10;
            }

            foreach (KeyValuePair<string, int> kvPair in inventory)
            {
                Console.WriteLine($"{kvPair.Key,10} = {kvPair.Value,-20}");
            }

        }//end main


        static void OldMain(string[] args)
        {
            Hashtable inventory = new Hashtable();
            inventory["apple"] = 12;
            inventory["bananas"] = 30;
            inventory["cherry"] = 40;
            inventory["durian"] = 1;

            Console.WriteLine(inventory["apple"] + ". How do you like them apples?");


            if (inventory["apple"] is int)
            {

                inventory["apple"] = (int)inventory["apple"] - 1;
            }

            Console.WriteLine(inventory["apple"] + ". How do you like them apples?");

            foreach (object key in inventory.Keys)
            {
                Console.WriteLine(key + "\t" + (int)inventory[key]);
            }

        }
    }
}
