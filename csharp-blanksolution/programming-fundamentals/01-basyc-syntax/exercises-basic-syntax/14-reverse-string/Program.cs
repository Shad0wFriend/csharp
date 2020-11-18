using System;

namespace _14_reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = "";

            int counter = input.Length - 1;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
