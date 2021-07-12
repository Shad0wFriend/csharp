using System;

namespace _01_return_the_sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(a, b));
        }

        public static int Sum(int a, int b) => a + b;
    }
}
