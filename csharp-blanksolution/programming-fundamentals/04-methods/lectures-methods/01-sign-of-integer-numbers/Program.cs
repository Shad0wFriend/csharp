using System;

namespace _01_sign_of_integer_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CheckSign(n);
        }

        public static void CheckSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {n} is negative.");
            }

        }
    }
}
