using System;

namespace _05_sumirane_na_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                sum += n;
            }

            Console.WriteLine(sum);
        }
    }
}
