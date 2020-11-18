using System;

namespace _06_middle_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            MiddleCharacters(text);
        }

        public static void MiddleCharacters(string text)
        {
            int length = text.Length;

            if (length % 2 == 0)
            {
                Console.WriteLine($"{text[(length / 2) - 1]}{text[length / 2]}");
            }
            else
            {
                Console.WriteLine($"{text[length / 2]}");
            }
        }
    }
}
