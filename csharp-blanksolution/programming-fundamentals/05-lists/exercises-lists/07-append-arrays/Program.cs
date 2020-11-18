using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string array = "";

            List<int> result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '|')
                {
                    int[] arr = array.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int k = arr.Length - 1; k >= 0; k--)
                    {
                        result.Insert(0, arr[k]);
                    }

                    array = "";

                    continue;
                }

                if (input[i] != ' ')
                {
                    array += input[i];
                }
                else
                {
                    array += " ";
                }

                if (i == input.Length - 1)
                {
                    int[] arr = array.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int k = arr.Length - 1; k >= 0; k--)
                    {
                        result.Insert(0, arr[k]);
                    }
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
