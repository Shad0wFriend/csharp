using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_car_race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int counter = numbers.Count - 1;

            int mid = numbers.Count / 2;

            double left = 0;

            double right = 0;

            double reduce = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == mid && counter == mid)
                {
                    if (left >= right)
                    {
                        Console.WriteLine($"The winner is right with total time: {right}");
                    }
                    else
                    {
                        Console.WriteLine($"The winner is left with total time: {left}");
                    }

                    break;
                }

                if (numbers[i] == 0)
                {
                    reduce = left * 0.2;

                    left -= reduce;
                }
                else
                {
                    left += numbers[i];
                }

                if (numbers[counter] == 0)
                {
                    reduce = right * 0.2;

                    right -= reduce;
                }
                else
                {
                    right += numbers[counter];
                }

                counter--;
            }
        }
    }
}
