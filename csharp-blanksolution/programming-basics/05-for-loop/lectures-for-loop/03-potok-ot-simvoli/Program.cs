using System;

namespace _03_potok_ot_simvoli
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
