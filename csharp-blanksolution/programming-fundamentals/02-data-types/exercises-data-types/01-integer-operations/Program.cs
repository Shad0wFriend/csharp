using System;

namespace _01_integer_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            long sum = a + b;

            long division = sum / c;

            long multiplication = division * d;

            Console.WriteLine(multiplication);
        }
    }
}
