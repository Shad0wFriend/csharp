using System;

namespace _15_refactoring_prime_checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;

            bool isPrime = false;

            for (int i = 2; i <= n; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    if (i % k == 0)
                    {
                        counter++;
                    }

                    if (counter == 2)
                    {
                        isPrime = true;
                    }
                    else if (counter > 2)
                    {
                        isPrime = false;

                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }

                counter = 0;
            }
        }
    }
}
