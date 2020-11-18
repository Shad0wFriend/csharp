using System;

namespace _05_add_and_subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);

            int subtract = Subtract(sum, c);

            Console.WriteLine(subtract);
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int sum, int c)
        {
            return sum - c;
        }
    }
}
