using System;
using System.Linq;

namespace _04_array_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rotations = int.Parse(Console.ReadLine());

            int lastNumber = numbers[0];

            for (int i = 0; i < rotations; i++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (k + 1 >= numbers.Length)
                    {
                        break;
                    }

                    numbers[k] = numbers[k + 1];
                }

                numbers[numbers.Length - 1] = lastNumber;
                lastNumber = numbers[0];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
