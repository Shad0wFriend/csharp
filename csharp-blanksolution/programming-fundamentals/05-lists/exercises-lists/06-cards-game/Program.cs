using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_cards_game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int length = Math.Max(first.Count, second.Count);

            for (int i = 0; i < length; i++)
            {
                length = Math.Max(first.Count, second.Count);

                if (first.Count == 0)
                {
                    Console.WriteLine("Second player wins! Sum: " + second.Sum());

                    break;
                }

                if (second.Count == 0)
                {
                    Console.WriteLine("First player wins! Sum: " + first.Sum());

                    break;
                }

                if (i >= first.Count || i >= second.Count)
                {
                    i = -1;

                    continue;
                }

                if (first[i] == second[i])
                {

                    first.RemoveAt(i);

                    second.RemoveAt(i);

                    i = -1;
                }
                else if (first[i] > second[i])
                {
                    first.Add(first[i]);

                    first.RemoveAt(i);

                    first.Add(second[i]);

                    second.RemoveAt(i);

                    i = -1;
                }
                else
                {
                    second.Add(second[i]);

                    second.RemoveAt(i);

                    second.Add(first[i]);

                    first.RemoveAt(i);

                    i = -1;
                }
            }
        }
    }
}
