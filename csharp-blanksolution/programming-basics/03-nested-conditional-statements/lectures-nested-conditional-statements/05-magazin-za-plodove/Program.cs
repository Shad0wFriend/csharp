using System;

namespace _05_magazin_za_plodove
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price;

            if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    price = quantity * 2.7;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "apple")
                {
                    price = quantity * 1.25;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "orange")
                {
                    price = quantity * 0.9;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "grapefruit")
                {
                    price = quantity * 1.6;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "kiwi")
                {
                    price = quantity * 3;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "pineapple")
                {
                    price = quantity * 5.6;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "grapes")
                {
                    price = quantity * 4.2;

                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    price = quantity * 2.5;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "apple")
                {
                    price = quantity * 1.2;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "orange")
                {
                    price = quantity * 0.85;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "grapefruit")
                {
                    price = quantity * 1.45;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "kiwi")
                {
                    price = quantity * 2.7;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "pineapple")
                {
                    price = quantity * 5.5;

                    Console.WriteLine($"{price:F2}");
                }
                else if (product == "grapes")
                {
                    price = quantity * 3.85;

                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
