using System;

namespace _04_printing_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTriangle(n);
        }

        public static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
