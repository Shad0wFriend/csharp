using System;
using System.Collections.Generic;

namespace _13_take_skip_rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<int> numbers = new List<int>();

            List<char> symbols = new List<char>();

            foreach (char symbol in text)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    numbers.Add(int.Parse(symbol.ToString()));
                }
                else
                {
                    symbols.Add(symbol);
                }
            }

            List<int> take = new List<int>();

            List<int> skip = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    take.Add(numbers[i]);
                }
                else
                {
                    skip.Add(numbers[i]);
                }
            }

            string result = "";

            int index = 0;

            for (int i = 0; i < take.Count; i++)
            {
                if (i == 0)
                {
                    result += Take(symbols, take[i], index);

                    index += take[i];

                    continue;
                }

                index += skip[i - 1];

                result += Take(symbols, take[i], index);

                index += take[i];
            }

            Console.WriteLine(result);
        }

        public static string Take(List<char> symbols, int amount, int index)
        {
            string result = "";

            int length = amount + index;

            for (int i = index; i < length; i++)
            {
                if (i >= symbols.Count)
                {
                    break;
                }

                result += symbols[i];
            }

            return result;
        }
    }
}
