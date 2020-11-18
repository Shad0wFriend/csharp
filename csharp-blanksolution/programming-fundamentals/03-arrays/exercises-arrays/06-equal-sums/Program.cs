using System;
using System.Linq;

namespace _06_equal_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine(0);

                return;
            }

            int leftSum = 0;

            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (k < i)
                    {
                        leftSum += numbers[k];
                    }
                    else
                    {
                        if (k == i)
                        {
                            continue;
                        }

                        rightSum += numbers[k];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);

                    return;
                }

                leftSum = 0;

                rightSum = 0;
            }

            Console.WriteLine("no");
        }
    }
}
