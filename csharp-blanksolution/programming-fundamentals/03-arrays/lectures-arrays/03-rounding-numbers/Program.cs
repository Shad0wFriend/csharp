using System;
using System.Linq;

namespace _03_rounding_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double number = Math.Round(numbers[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{numbers[i]} => {number}");
            }
        }
    }
}
