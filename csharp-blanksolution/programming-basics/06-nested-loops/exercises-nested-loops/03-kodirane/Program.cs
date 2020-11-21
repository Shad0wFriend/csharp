using System;

namespace _03_kodirane
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int lenght = input.Length;

            int n = int.Parse(input);

            for (int rows = 1; rows <= lenght; rows++)
            {
                int lastDiggit = n % 10;

                char symbol = (char)(lastDiggit + 33);

                for (int k = 0; k < lastDiggit; k++)
                {
                    Console.Write(symbol);
                }

                if (lastDiggit == 0)
                {
                    Console.Write("ZERO");
                }

                Console.WriteLine();

                n = n / 10;
            }
        }
    }
}
