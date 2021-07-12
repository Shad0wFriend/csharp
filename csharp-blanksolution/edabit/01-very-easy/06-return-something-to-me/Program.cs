using System;

namespace _06_return_something_to_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine(Concat(input));
        }

        public static string Concat(string input) => $"something {input}";
    }
}
