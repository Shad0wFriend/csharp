﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_sum_adjacent_equal_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + 1 >= numbers.Count)
                {
                    break;
                }

                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] = numbers[i] + numbers[i];

                    numbers.RemoveAt(i + 1);

                    i = -1;
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}