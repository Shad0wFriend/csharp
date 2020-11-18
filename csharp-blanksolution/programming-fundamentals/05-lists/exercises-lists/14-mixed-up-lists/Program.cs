using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_mixed_up_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int counter = second.Count - 1;

            List<int> tmp = new List<int>();

            int start = 0;

            int end = 0;

            for (int i = 0; ; i++)
            {
                if (first.Count == 2 && second.Count < 2)
                {
                    end = Math.Max(first[0], first[1]);

                    start = Math.Min(first[0], first[1]);

                    break;
                }
                else if (first.Count < 2 && second.Count == 2)
                {
                    end = Math.Max(second[0], second[1]);

                    start = Math.Min(second[0], second[1]);

                    break;
                }

                tmp.Add(first[i]);

                first.RemoveAt(i);

                tmp.Add(second[counter]);

                second.RemoveAt(counter);

                counter--;

                i = -1;
            }

            List<int> result = new List<int>();

            int index = 0;

            for (int i = 0; ; i++)
            {
                if (i >= tmp.Count)
                {
                    break;
                }

                int smallest = tmp[i];

                for (int k = 0; k < tmp.Count; k++)
                {
                    if (tmp.Count == 1)
                    {
                        smallest = tmp[0];

                        index = 0;

                        break;
                    }

                    if (smallest >= tmp[k])
                    {
                        smallest = tmp[k];

                        index = k;
                    }
                }

                result.Add(smallest);

                tmp.RemoveAt(index);

                i = -1;
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] <= start)
                {
                    result.RemoveAt(0);

                    i = -1;
                }
                else
                {
                    break;
                }
            }

            int boundary = result.Count - 1;

            for (int i = result.Count - 1; i >= 0; i--)
            {
                if (result[i] >= end)
                {
                    result.RemoveAt(boundary);

                    i = boundary;

                    boundary--;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
