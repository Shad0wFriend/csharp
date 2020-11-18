using System;

namespace _06_strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;
            int temporarySum = 1;

            foreach (char symbol in input)
            {
                string parsedString = symbol.ToString();

                int digit = int.Parse(parsedString);

                for (int i = 1; i <= digit; i++)
                {
                    temporarySum *= i;
                }

                sum += temporarySum;

                temporarySum = 1;
            }

            int n = int.Parse(input);

            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
