using System;

namespace _05_orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "water": PrintPrice(quantity, 1.00); break;
                case "coffee": PrintPrice(quantity, 1.50); break;
                case "coke": PrintPrice(quantity, 1.40); break;
                case "snacks": PrintPrice(quantity, 2.00); break;
            }
        }

        public static void PrintPrice(int quantity, double price)
        {
            Console.WriteLine($"{(quantity * price):F2}");
        }
    }
}
