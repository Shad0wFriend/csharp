using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_remove_negative_and_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);

                    i = -1;
                }
            }

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }
    }
}
