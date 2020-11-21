using System;

namespace _09_kyshichka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counterStars = 2;
            int counterDashes = n / 2;
            int boundary = (n / 2) + 1;

            string stars = "";
            string dashes = "";

            if (n % 2 == 0)
            {
                switch (n)
                {
                    case 2: counterDashes = 0; boundary = 0; break;
                    case 4: counterDashes = 1; boundary = 2; break;
                    default: counterDashes = (n / 2) - 1; break;
                }

                for (int i = 1; i <= n / 2; i++)
                {
                    stars = new string('*', counterStars);
                    dashes = new string('-', counterDashes);

                    Console.WriteLine(dashes + stars + dashes);

                    counterStars += 2;
                    counterDashes--;
                }

                for (int i = 1; i <= n / 2; i++)
                {
                    stars = new string('*', n - 2);

                    Console.WriteLine('|' + stars + '|');
                }
            }
            else
            {
                counterStars = 1;

                for (int i = 1; i <= boundary; i++)
                {
                    stars = new string('*', counterStars);
                    dashes = new string('-', counterDashes);

                    Console.WriteLine(dashes + stars + dashes);

                    counterStars += 2;
                    counterDashes--;
                }

                if (n == 3)
                {
                    boundary = 1;
                }
                else if (n > 5)
                {
                    boundary = n - 2;
                }

                for (int i = 1; i <= n / 2; i++)
                {
                    stars = new string('*', boundary);

                    Console.WriteLine('|' + stars + '|');
                }
            }
        }
    }
}
