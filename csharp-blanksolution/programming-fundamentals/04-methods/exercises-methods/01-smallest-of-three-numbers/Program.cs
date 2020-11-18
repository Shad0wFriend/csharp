using System;

namespace _01_smallest_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            int c = int.Parse(Console.ReadLine());

            int result = Smallest(a, b, c);

            Console.WriteLine(result);
        }

        public static int Smallest(int a, int b, int c)
        {
            int smallest = 0;

            if ((a >= b && b >= c) || (b >= a && a >= c))
            {
                smallest = c;
            }
            else if ((b >= c && c >= a) || (c >= b && b >= a))
            {
                smallest = a;
            }
            else if ((c >= a && a >= b) || (a >= c && c >= b))
            {
                smallest = b;
            }

            return smallest;
        }
    }
}
