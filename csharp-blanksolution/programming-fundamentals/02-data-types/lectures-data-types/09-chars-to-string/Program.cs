using System;

namespace _09_chars_to_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string concat = "";

            for (int i = 0; i <= 2; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                concat += symbol;
            }

            Console.WriteLine(concat);
        }
    }
}
