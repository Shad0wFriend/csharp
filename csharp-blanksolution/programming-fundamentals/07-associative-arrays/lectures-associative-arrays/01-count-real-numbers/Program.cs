using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_count_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> occurancesCount = new SortedDictionary<double, int>();
        }
    }
}
