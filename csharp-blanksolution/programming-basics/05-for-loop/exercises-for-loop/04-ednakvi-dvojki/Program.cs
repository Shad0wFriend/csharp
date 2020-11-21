using System;

namespace _04_ednakvi_dvojki
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int biggestSum = int.MinValue;
            int smallestSum = int.MaxValue;
            int sum = 0;
            int pairSum = 0;
            int diff = 0;

            for (int i = 1; i <= 2 * countOfNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                pairSum += n;

                if (i % 2 == 0)
                {
                    if (biggestSum < pairSum)
                    {
                        biggestSum = pairSum;
                    }

                    if (smallestSum > pairSum)
                    {
                        smallestSum = pairSum;
                    }

                    diff = biggestSum - sum;

                    sum = pairSum;

                    pairSum = 0;
                }
            }

            if (biggestSum == smallestSum)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                if (diff == 0)
                {
                    int difference = biggestSum - smallestSum;

                    Console.WriteLine($"No, maxdiff={difference}");
                }
                else
                {
                    Console.WriteLine($"No, maxdiff={diff}");
                }
            }
        }
    }
}
