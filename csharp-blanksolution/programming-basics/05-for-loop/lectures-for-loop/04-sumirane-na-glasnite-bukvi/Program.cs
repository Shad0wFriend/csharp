using System;

namespace _04_sumirane_na_glasnite_bukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int counter = 0;

            foreach (char letter in word)
            {
                switch (letter)
                {
                    case 'a': counter += 1; break;
                    case 'e': counter += 2; break;
                    case 'i': counter += 3; break;
                    case 'o': counter += 4; break;
                    case 'u': counter += 5; break;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
