using System;

namespace _05_lodka_za_ribolov
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishers = int.Parse(Console.ReadLine());

            double rent = 0;

            switch (season)
            {
                case "Spring": rent = 3000; break;
                case "Summer":
                case "Autumn": rent = 4200; break;
                case "Winter": rent = 2600; break;
            }

            double cost = 0;

            if (numberOfFishers <= 6)
            {
                cost = rent - (rent * 0.1);
            }
            else if (numberOfFishers > 6 && numberOfFishers <= 11)
            {
                cost = rent - (rent * 0.15);
            }
            else if (numberOfFishers > 11)
            {
                cost = rent - (rent * 0.25);
            }

            if (numberOfFishers % 2 == 0 && season != "Autumn")
            {
                double discount = cost * 0.05;
                cost = cost - discount;
            }

            if (cost > budget)
            {
                Console.WriteLine($"Not enough money! You need {(cost - budget):F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {(budget - cost):F2} leva left.");
            }
        }
    }
}
