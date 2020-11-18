using System;

namespace _13_recursive_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            CalculateNumber(n, 1, 1, 1);
        }

        public static void CalculateNumber(int n, int counter, int current, int previous)
        {
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if (n == 2)
            {
                Console.WriteLine(1);
                return;
            }
            else
            {
                if (counter == n - 2)
                {
                    Console.WriteLine(current + previous);
                    return;
                }

                current = current + previous;

                previous = current - previous;

                counter++;
            }

            CalculateNumber(n, counter, current, previous);
        }
    }
}
