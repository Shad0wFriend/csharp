using System;

namespace _08_factorial_divisions
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());

            long b = long.Parse(Console.ReadLine());

            double result = Factorial(a) / Factorial(b);

            Console.WriteLine($"{result:F2}");
        }

        public static double Factorial(double n)
        {
            long result = 1;

            if (n == 0)
            {
                return 1;
            }

            for (long i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
