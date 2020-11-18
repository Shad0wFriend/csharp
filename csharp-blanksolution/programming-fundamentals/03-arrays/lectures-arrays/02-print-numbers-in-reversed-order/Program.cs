using System;

namespace _02_print_numbers_in_reversed_order
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            int[] reversed = new int[countOfLines];

            for (int i = 0; i < countOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());

                reversed[i] = number;
            }

            Array.Reverse(reversed);

            for (int i = 0; i < reversed.Length; i++)
            {
                Console.Write(reversed[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
