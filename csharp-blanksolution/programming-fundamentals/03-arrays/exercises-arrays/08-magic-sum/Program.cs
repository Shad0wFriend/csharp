using System;
using System.Linq;

namespace _08_magic_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int magicNumber = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] + numbers[k] == magicNumber)
                    {
                        if (numbers[k] == first || numbers[k] == second)
                        {
                            numbers[k] = 0;
                        }
                        else
                        {
                            first = numbers[i];

                            second = numbers[k];

                            Console.WriteLine(numbers[i] + " " + numbers[k]);
                        }
                    }
                }
            }
        }
    }
}
