using System;

namespace _04_nov_dom
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flower)
            {
                case "Roses": price = 5; break;
                case "Dahlias": price = 3.8; break;
                case "Tulips": price = 2.8; break;
                case "Narcissus": price = 3; break;
                case "Gladiolus": price = 2.5; break;
            }

            double cost = price * numberOfFlowers;

            if (numberOfFlowers > 80 && flower == "Roses")
            {
                cost = cost - (cost * 0.1);
            }
            else if (numberOfFlowers > 90 && flower == "Dahlias")
            {
                cost = cost - (cost * 0.15);
            }
            else if (numberOfFlowers > 80 && flower == "Tulips")
            {
                cost = cost - (cost * 0.15);
            }
            else if (numberOfFlowers < 120 && flower == "Narcissus")
            {
                cost = cost + (cost * 0.15);
            }
            else if (numberOfFlowers < 80 && flower == "Gladiolus")
            {
                cost = cost + (cost * 0.2);
            }

            if (cost > budget)
            {
                Console.WriteLine($"Not enough money, you need {(cost - budget):F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flower} and {(budget - cost):F2} leva left.");
            }
        }
    }
}
