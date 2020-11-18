using System;
using System.Linq;

namespace _14_fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = (arr.Length / 4) - 1;

            int t = arr.Length / 4;

            for (int i = 1; i <= arr.Length / 2; i++)
            {
                if (i <= arr.Length / 4)
                {
                    Console.Write(arr[k] + arr[t] + " ");

                    k--;
                    t++;

                    if (i == arr.Length / 4)
                    {
                        k = arr.Length / 2;
                        t = arr.Length - 1;
                    }
                }
                else
                {
                    Console.Write(arr[k] + arr[t] + " ");

                    k++;
                    t--;
                }
            }
        }
    }
}
