using System;

namespace _11_math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            char symbol = char.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            double result = Operation(a, b, symbol);

            Console.WriteLine(Math.Round(result, 2));
        }

        public static double Operation(int a, int b, char symbol)
        {
            double result = 0;

            switch (symbol)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = a / b; break;
            }

            return result;
        }
    }
}
