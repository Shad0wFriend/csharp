using System;

namespace _02_pounds_to_dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = 1.31M;

            decimal result = pounds * dollars;

            Console.WriteLine($"{result:F3}");
        }
    }
}
