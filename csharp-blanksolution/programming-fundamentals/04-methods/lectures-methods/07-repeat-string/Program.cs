using System;

namespace _07_repeat_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int repetitions = int.Parse(Console.ReadLine());

            string result = ConcatText(text, repetitions);

            Console.WriteLine(result);
        }

        public static string ConcatText(string text, int repetitions)
        {
            string result = "";

            for (int i = 0; i < repetitions; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
