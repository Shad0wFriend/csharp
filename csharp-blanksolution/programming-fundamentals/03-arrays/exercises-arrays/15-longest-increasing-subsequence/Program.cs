using System;
using System.Linq;

namespace _15_longest_increasing_subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startNumber = 0;

            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                //arr[0] = 0 arr[1] = -1 ?
                if (arr[0] == 0)
                {
                    startNumber = 0;
                    break;
                }

                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] > arr[k])
                    {
                        break;
                    }
                    else
                    {
                        if (arr[i] + arr[i] >= arr[k] && arr[i] < 10)
                        {
                            startNumber = arr[i];
                            isFound = true;
                            break;
                        }
                    }
                }

                if (isFound)
                {
                    break;
                }

                if (i == arr.Length - 1)
                {
                    startNumber = arr[i];
                }
            }

            if (arr.Length == 1)
            {
                startNumber = arr[0];
            }
            else if (startNumber == 0)
            {
                Console.Write(startNumber + " ");
                startNumber = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (startNumber + startNumber >= arr[i] && startNumber <= arr[i])
                {
                    startNumber = arr[i];

                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
