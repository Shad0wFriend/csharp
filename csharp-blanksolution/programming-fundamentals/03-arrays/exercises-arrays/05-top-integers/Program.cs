using System;
using System.Linq;

namespace _05_top_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int topIntegersCounter = 0;

            bool isTopInteger = false;

            string topIntegers = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i; k < numbers.Length; k++)
                {
                    if (numbers[i] >= numbers[k])
                    {
                        isTopInteger = true;
                    }
                    else
                    {
                        isTopInteger = false;
                    }

                    if (isTopInteger == false)
                    {
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers += numbers[i].ToString() + " ";

                    topIntegersCounter++;
                }
            }

            string[] integers = topIntegers.Split(' ');

            for (int i = 0; i < integers.Length; i++)
            {
                if (i > 0 && integers[i - 1] == integers[i])
                {
                    continue;
                }

                Console.Write(integers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
