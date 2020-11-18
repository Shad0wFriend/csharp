using System;
using System.Linq;

namespace _07_equal_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int index = 0;

            bool isEqual = false;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    sum += first[i];

                    isEqual = true;
                }
                else
                {
                    index = i;

                    isEqual = false;

                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
