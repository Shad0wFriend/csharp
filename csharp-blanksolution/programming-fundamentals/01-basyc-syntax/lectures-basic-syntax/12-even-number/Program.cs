using System;

namespace _12_even_number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                n = Math.Abs(n);

                if (n % 2 == 0)
                {
                    Console.WriteLine($"The number is: {n}");

                    break;
                }
                else
                {
                    Console.WriteLine($"Please write an even number.");

                    continue;
                }
            }
        }
    }
}
