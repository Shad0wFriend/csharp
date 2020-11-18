using System;
using System.Numerics;

namespace _03_exact_sum_of_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int counter = 0;

            BigInteger sumInteger = 0;

            decimal sumReal = 0M;

            while (true)
            {
                if (counter == countOfNumbers)
                {
                    if (sumInteger == 0)
                    {
                        Console.WriteLine(sumReal);
                    }
                    else if (sumReal == 0)
                    {
                        Console.WriteLine(sumInteger);
                    }
                    else
                    {
                        decimal result = (decimal)sumInteger + sumReal;

                        BigInteger number = (BigInteger)sumReal; //not included in the solution, for my understanding

                        Console.WriteLine(result);
                    }

                    break;
                }

                string parsedNumber = Console.ReadLine();

                try
                {
                    BigInteger number = BigInteger.Parse(parsedNumber);

                    sumInteger += number;
                }
                catch
                {
                    decimal number = decimal.Parse(parsedNumber);

                    sumReal += number;
                }

                counter++;
            }
        }
    }
}
