using System;

namespace _02_kvartalno_magazinche
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price;

            if (product == "coffee")
            {
                if (town == "Sofia")
                {
                    price = quantity * 0.5;

                    Console.WriteLine(price);
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 0.4;

                    Console.WriteLine(price);
                }
                else
                {
                    price = quantity * 0.45;

                    Console.WriteLine(price);
                }
            }
            else if (product == "water")
            {
                if (town == "Sofia")
                {
                    price = quantity * 0.8;

                    Console.WriteLine(price);
                }
                else
                {
                    price = quantity * 0.7;

                    Console.WriteLine(price);
                }
            }
            else if (product == "beer")
            {
                if (town == "Sofia")
                {
                    price = quantity * 1.2;

                    Console.WriteLine(price);
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 1.15;

                    Console.WriteLine(price);
                }
                else
                {
                    price = quantity * 1.1;

                    Console.WriteLine(price);
                }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia")
                {
                    price = quantity * 1.45;

                    Console.WriteLine(price);
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 1.3;

                    Console.WriteLine(price);
                }
                else
                {
                    price = quantity * 1.35;

                    Console.WriteLine(price);
                }
            }
            else
            {
                if (town == "Sofia")
                {
                    price = quantity * 1.6;

                    Console.WriteLine(price);
                }
                else if (town == "Plovdiv")
                {
                    price = quantity * 1.5;

                    Console.WriteLine(price);
                }
                else
                {
                    price = quantity * 1.55;

                    Console.WriteLine(price);
                }
            }
        }
    }
}
