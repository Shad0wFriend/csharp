using System;
using System.Linq;

namespace _08_condense_array_to_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int number = 0;

            int[] temp = numbers;

            for (int i = 2; i < numbers.Length; i++)
            {
                for (int k = 0; k < temp.Length; k++)
                {
                    if (k + 1 >= temp.Length)
                    {
                        break;
                    }
                    else
                    {
                        number = numbers[k] + numbers[k + 1];

                        temp[k] = number;
                    }
                }
            }

            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            }
            else
            {
                Console.WriteLine(temp[0] + temp[1]);
            }
        }
    }
}
