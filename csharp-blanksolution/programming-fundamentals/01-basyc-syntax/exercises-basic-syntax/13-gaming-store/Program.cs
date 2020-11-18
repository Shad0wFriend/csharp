using System;

namespace _13_gaming_store
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            double money = 0;

            double expenditure = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${expenditure:F2}. Remaining: ${money:F2}");

                    break;
                }

                if (counter == 0)
                {
                    money = double.Parse(input);

                    counter++;

                    continue;
                }

                double price = 0;

                bool isNotFound = false;

                switch (input)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default: Console.WriteLine("Not Found"); isNotFound = true; break;
                }

                if (isNotFound == false)
                {
                    if (money >= price)
                    {
                        Console.WriteLine("Bought " + input);

                        money -= price;

                        expenditure += price;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");

                        continue;
                    }
                }
                else
                {
                    continue;
                }

                if (money == 0)
                {
                    Console.WriteLine("Out of money!");

                    break;
                }

                counter++;
            }
        }
    }
}
