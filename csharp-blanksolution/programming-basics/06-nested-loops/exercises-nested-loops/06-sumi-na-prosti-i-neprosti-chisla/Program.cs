using System;

namespace _06_sumi_na_prosti_i_neprosti_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
                    Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");

                    break;
                }

                int n = int.Parse(input);

                if (n < 0)
                {
                    Console.WriteLine("Number is negative.");

                    continue;
                }

                int counter = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 2)
                {
                    primeSum += n;
                }
                else
                {
                    nonPrimeSum += n;
                }
            }
        }
    }
}
