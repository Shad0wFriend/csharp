using System;

namespace _06_triples_of_latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstCntr = 0;
            int secondCntr = 0;
            int thirdCntr = 0;

            char firstSymbol = ' ';

            for (char first = 'a'; firstCntr + 1 <= n; first = firstSymbol)
            {
                for (char second = 'a'; secondCntr + 1 <= n; second = (char)(97 + secondCntr))
                {
                    for (char third = 'a'; thirdCntr + 1 <= n; third = (char)(97 + thirdCntr))
                    {
                        Console.WriteLine($"{first}{second}{third}");

                        thirdCntr++;
                    }

                    thirdCntr = 0;

                    secondCntr++;
                }

                secondCntr = 0;

                firstCntr++;

                firstSymbol = (char)(97 + firstCntr);
            }
        }
    }
}
