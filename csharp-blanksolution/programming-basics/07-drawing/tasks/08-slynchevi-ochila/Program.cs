using System;

namespace _08_slynchevi_ochila
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 1;
            int middle = 0;
            int boundary = 2 * n;

            string stars = new string('*', boundary);
            string whieSpaces = new string(' ', n);
            string centerSymbols = new string('|', n);
            string slashes = new string('/', boundary - 2);

            if (n % 2 == 0)
            {
                middle = n / 2;
            }
            else
            {
                if (n == 3)
                {
                    middle = 2;
                }
                else
                {
                    middle = (n / 2) + 1;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.WriteLine(stars + whieSpaces + stars);

                    counter++;

                    continue;
                }

                if (counter == middle)
                {
                    Console.WriteLine('*' + slashes + '*' + centerSymbols + '*' + slashes + '*');
                }
                else
                {
                    Console.WriteLine('*' + slashes + '*' + whieSpaces + '*' + slashes + '*');
                }

                counter++;
            }
        }
    }
}
