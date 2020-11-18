using System;

namespace _03_characters_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());

            char end = char.Parse(Console.ReadLine());

            PrintAsciInRange(start, end);
        }

        public static void PrintAsciInRange(char start, char end)
        {
            if ((int)start > (int)end)
            {
                char tmp = start;
                start = end;
                end = tmp;
            }

            int counter = start + 1;

            for (char symbol = (char)(start + 1); counter < end; symbol = (char)(counter))
            {
                Console.Write(symbol + " ");
                counter++;
            }
        }
    }
}
