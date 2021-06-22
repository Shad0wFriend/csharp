using System;

namespace _01_find_the_bomb
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(CheckForBomb(input));
        }

        public static string CheckForBomb(string input) => input.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
    }
}
