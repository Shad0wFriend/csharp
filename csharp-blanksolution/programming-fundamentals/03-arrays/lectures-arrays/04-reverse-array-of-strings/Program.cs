using System;

namespace _04_reverse_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Array.Reverse(input);

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
