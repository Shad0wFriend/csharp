using System;
using System.Linq;

namespace _03_zig_zag_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int counter = 0;

            int[] first = new int[countOfLines];
            int[] second = new int[countOfLines];

            while (counter < countOfLines)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if ((counter + 1) % 2 == 1)
                    {
                        first[counter] = numbers[i];
                        second[counter] = numbers[i + 1];
                        break;
                    }
                    else
                    {
                        first[counter] = numbers[i + 1];
                        second[counter] = numbers[i];
                        break;
                    }
                }

                counter++;
            }

            for (int i = 0; i < first.Length; i++)
            {
                Console.Write(first[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < second.Length; i++)
            {
                Console.Write(second[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
