using System;

namespace _05_return_the_remainder_from_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine(Remainder(a, b));
        }

        public static int Remainder(int a, int b) => a % b;
    }
}
