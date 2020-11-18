using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_gauss_trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int counter = numbers.Count - 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == counter)
                {
                    break;
                }

                numbers[i] = numbers[i] + numbers[counter];

                numbers.RemoveAt(counter);

                counter--;
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
