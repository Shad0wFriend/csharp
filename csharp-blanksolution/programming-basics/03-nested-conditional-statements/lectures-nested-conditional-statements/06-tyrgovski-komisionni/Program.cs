using System;

namespace _06_tyrgovski_komisionni
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double commission;

            if (town == "Sofia")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = sells * 5 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = sells * 7 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = sells * 8 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 10000)
                {
                    commission = sells * 12 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = sells * 45 / 1000;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = sells * 75 / 1000;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = sells * 10 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 10000)
                {
                    commission = sells * 13 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (sells >= 0 && sells <= 500)
                {
                    commission = sells * 55 / 1000;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 500 && sells <= 1000)
                {
                    commission = sells * 8 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 1000 && sells <= 10000)
                {
                    commission = sells * 12 / 100;

                    Console.WriteLine($"{commission:F2}");
                }
                else if (sells > 10000)
                {
                    commission = sells * 145 / 1000;

                    Console.WriteLine($"{commission:F2}");
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
