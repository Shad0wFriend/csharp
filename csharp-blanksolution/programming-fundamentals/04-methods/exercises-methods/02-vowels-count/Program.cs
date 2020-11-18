using System;

namespace _02_vowels_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int result = Vowels(text);

            Console.WriteLine(result);
        }

        public static int Vowels(string text)
        {
            int counter = 0;

            foreach (char symbol in text)
            {
                switch (symbol)
                {
                    case 'a': counter++; break;
                    case 'e': counter++; break;
                    case 'u': counter++; break;
                    case 'i': counter++; break;
                    case 'o': counter++; break;
                    case 'y': counter++; break;
                    case 'A': counter++; break;
                    case 'E': counter++; break;
                    case 'U': counter++; break;
                    case 'I': counter++; break;
                    case 'O': counter++; break;
                    case 'Y': counter++; break;
                }
            }

            return counter;
        }
    }
}
