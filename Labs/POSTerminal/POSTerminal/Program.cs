using System;
using System.Diagnostics;
using System.IO;

namespace POSTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Directory.GetCurrentDirectory() + @"\seaShanty2.wav"; //gets directory for .wav file location
            int menu, selection, qty;
            double cash;
            Inventory inventory = new Inventory();
            Transaction transaction = new Transaction();

            inventory.InitializeInventory();

            Cart cart = new Cart();

            PlaySound(file);

            do
            {
                PirateShopIntro();
                inventory.DisplayInventory();
                menu = IntInput("\nPlease select your option\n1. Purchase splendor (Buy an Item)\n2. Settle up! (Checkout)\n3. Clear the Seas! (Clear the console)\n" +
                    "4. Show yer loot!\n(Input a negative to hoist anchor and leave port!) >> ");
                switch (menu)
                {
                    case 1:
                        selection = IntInput("\nEnter ID for Item you would like to purchase? >> ");
                        while (selection <= 0 || selection > inventory.ReturnProducts().Count)
                        {
                            selection = IntInput("Not a valid input, what would you like to buy? >> ");
                        }
                        do
                        {
                            qty = IntInput("How many would you like to purchase? >> ");
                        } while (qty < 0);
                        cart.CartAdd(inventory.ReturnProducts(), selection - 1, qty);
                        Console.WriteLine($"\nYou have added {qty} {inventory.ReturnProducts()[selection - 1].ProductName}'s");
                        break;
                    case 2:
                        Console.Clear();
                        transaction.CalculateTransaction(inventory.ReturnProducts(), cart.ReturnCart());
                        transaction.DisplayReciept();
                        cash = DoubleInput("\nEnter how much coin ye are paying with >> ");
                        while (cash < transaction.GrandTotal())
                        {
                            cash = DoubleInput("\nListen here Scallywag!! THATS NOT ENOUGH COIN!! TRY AGAIN!!\nEnter how much coin ye are paying with >> ");
                        }
                        transaction.CalcChange(cash);
                        transaction.ClearTransaction(cart.ReturnCart());
                        break;
                    case 3:
                        Console.Clear();
                        inventory.DisplayInventory();
                        break;
                    case 4:
                        Console.Clear();
                        cart.DisplayCart();
                        Console.WriteLine("Press [enter] to go back to shop");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (menu > 0);
            Console.WriteLine("As you leave, four ships sail over and open fire... your ship sinks and you LOSE ALL YER LOOT!!");
        }
        public static void PlaySound(string file) //this is used to run a powershell script to play the sound at file dir
        {
            Process.Start(@"powershell", $@"-c (New-Object Media.SoundPlayer '{file}').PlaySync();");
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
        private static double DoubleInput(string text)
        {
            Console.Write($"{text}");
            string s = Console.ReadLine();
            bool worked = double.TryParse(s, out double x);

            while (!worked)
            {
                Console.Write($"\n**Input not accepted**\n{text}");
                s = Console.ReadLine();
                worked = double.TryParse(s, out x);
            }
            return x;
        }
        static void PirateShopIntro()
        {
            Console.WriteLine(@"                       ______");
            Console.WriteLine(@"                    .-`      `-.");
            Console.WriteLine(@"                   /            \");
            Console.WriteLine(@"       _          |              |          _");
            Console.WriteLine(@"      ( \         |,  .-.  .-.  ,|         / )");
            Console.WriteLine(@"       > ` =._    | )(__ /  \__)(|    _.= ` <");
            Console.WriteLine(@"      (_/` =._`=._|/     /\     \|_.=`_.= `\_)");
            Console.WriteLine(@"             ` =._(_     ^^     _)`_.=`");
            Console.WriteLine(@"                 `=\__|IIIIII|__/=`");
            Console.WriteLine(@"                _.=`| \IIIIII / | `=._");
            Console.WriteLine(@"      _     _.=`_.=`\           /`=._`=._     _");
            Console.WriteLine(@"     ( \_.=`_.=`     `---------`     `=._`=._/ )");
            Console.WriteLine(@"      > _.=`                            `=._ <");
            Console.WriteLine(@"     (_/                                    \_)");
            Console.WriteLine();
            Console.WriteLine("Wellcome to the Quartermasters!! Make sure to bring yer Dubloons!!\n");
        }
    }
}
