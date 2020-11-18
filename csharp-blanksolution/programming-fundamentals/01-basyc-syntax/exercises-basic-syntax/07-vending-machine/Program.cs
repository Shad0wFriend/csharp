using System;

namespace _07_vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }

                switch (input)
                {
                    case "0.1": money += double.Parse(input); break;
                    case "0.2": money += double.Parse(input); break;
                    case "0.5": money += double.Parse(input); break;
                    case "1": money += double.Parse(input); break;
                    case "2": money += double.Parse(input); break;
                    default: Console.WriteLine("Cannot accept " + input); break;
                }
            }

            double price = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine($"Change: {money:F2}");

                    break;
                }

                bool isInvalidProduct = false;

                switch (input)
                {
                    case "Nuts": price = 2; break;
                    case "Water": price = 0.7; break;
                    case "Crisps": price = 1.5; break;
                    case "Soda": price = 0.8; break;
                    case "Coke": price = 1; break;
                    default: Console.WriteLine("Invalid product"); isInvalidProduct = true; break;
                }

                if (isInvalidProduct == true)
                {
                    continue;
                }

                if (money >= price)
                {
                    Console.WriteLine("Purchased " + input.ToLower());

                    money -= price;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
        }
    }
}
