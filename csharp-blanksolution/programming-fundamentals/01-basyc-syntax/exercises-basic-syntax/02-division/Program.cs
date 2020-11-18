using System;

namespace _02_division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            if (n % 2 == 0)
            {
                max = 2;
            }

            if (n % 3 == 0)
            {
                max = 3;
            }

            if (n % 6 == 0)
            {
                max = 6;
            }

            if (n % 7 == 0)
            {
                max = 7;
            }

            if (n % 10 == 0)
            {
                max = 10;
            }

            if (max == int.MinValue)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {max}");
            }
        }
    }
}
