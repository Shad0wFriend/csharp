using System;

namespace _05_print_part_of_the_ascii_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                char symbol = (char)(start + counter);

                counter++;

                Console.Write(symbol + " ");
            }
        }
    }
}
