using System;

namespace _02_bonus_tochki
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double points = 0.0;

            if (n % 2 == 0)
            {
                points += 1;
            }
            else if (n % 5 == 0)
            {
                points += 2;
            }

            if (n <= 100)
            {
                points += 5;
            }
            else if (n > 100 && n <= 1000)
            {
                points += n * 0.2;
            }
            else
            {
                points += n * 0.1;
            }

            Console.WriteLine(points);
            Console.WriteLine(n + points);
        }
    }
}
