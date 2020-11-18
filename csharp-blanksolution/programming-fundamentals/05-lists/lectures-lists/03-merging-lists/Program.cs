using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_merging_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> first = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            List<long> second = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            int length = 2 * Math.Min(first.Count, second.Count);

            List<long> biggest = new List<long>();

            int max = first.Count + second.Count;

            List<long> result = new List<long>();

            int index = 0;

            int firstCounter = 0;

            int secondCounter = 0;

            for (int i = 0; i < length; i++)
            {
                if (i == length - 1)
                {
                    index = firstCounter;
                }

                if (i % 2 == 0)
                {
                    result.Add(first[firstCounter]);

                    firstCounter++;
                }
                else
                {
                    result.Add(second[secondCounter]);

                    secondCounter++;
                }
            }

            FillBiggestList(first, second, biggest);

            for (int i = index; i < biggest.Count; i++)
            {
                result.Add(biggest[i]);
            }

            Console.WriteLine(string.Join(' ', result));
        }

        public static void FillBiggestList(List<long> first, List<long> second, List<long> biggest)
        {
            if (first.Count > second.Count)
            {
                for (int i = 0; i < first.Count; i++)
                {
                    biggest.Add(first[i]);
                }
            }
            else if (first.Count < second.Count)
            {
                for (int i = 0; i < second.Count; i++)
                {
                    biggest.Add(second[i]);
                }
            }
        }
    }
}
