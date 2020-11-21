using System;

namespace _10_diamant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countOutterDashes = (n - 2) / 2;
            int countInnerDashes = 2;

            string dashesOutter = "";
            string dashesInner = "";

            if (n % 2 == 0)
            {
                if (n == 2)
                {
                    countOutterDashes = 0;
                }
                else if (n == 4)
                {
                    countOutterDashes = 1;
                    countInnerDashes = 2;
                }
                else if (n > 4)
                {
                    countOutterDashes = (n - 2) / 2;
                    countInnerDashes = 2;
                }

                for (int i = 1; i <= n / 2; i++)
                {
                    dashesOutter = new string('-', countOutterDashes);
                    dashesInner = new string('-', countInnerDashes);

                    if (i == 1)
                    {
                        Console.WriteLine(dashesOutter + "**" + dashesOutter);

                        countOutterDashes--;

                        continue;
                    }
                    else
                    {
                        Console.WriteLine(dashesOutter + '*' + dashesInner + '*' + dashesOutter);
                    }

                    countOutterDashes--;
                    countInnerDashes += 2;
                }

                int boundary = (n - (n / 2)) - 1;

                countOutterDashes = 1;

                countInnerDashes -= 4;

                for (int i = 1; i <= boundary; i++)
                {
                    dashesOutter = new string('-', countOutterDashes);
                    dashesInner = new string('-', countInnerDashes);

                    if (i == boundary)
                    {
                        Console.WriteLine(dashesOutter + "**" + dashesOutter);
                    }
                    else
                    {
                        Console.WriteLine(dashesOutter + '*' + dashesInner + '*' + dashesOutter);
                    }

                    countOutterDashes++;
                    countInnerDashes -= 2;
                }
            }
            else
            {
                if (n == 1)
                {
                    countOutterDashes = 0;
                }
                else if (n == 3)
                {
                    countOutterDashes = 1;
                }
                else if (n > 3)
                {
                    countOutterDashes = n / 2;
                }

                countInnerDashes = 1;

                int boundary = (n / 2) + 1;

                for (int i = 1; i <= boundary; i++)
                {
                    dashesOutter = new string('-', countOutterDashes);
                    dashesInner = new string('-', countInnerDashes);

                    if (i == 1)
                    {
                        Console.WriteLine(dashesOutter + '*' + dashesOutter);

                        countOutterDashes--;

                        continue;
                    }
                    else
                    {
                        Console.WriteLine(dashesOutter + '*' + dashesInner + '*' + dashesOutter);
                    }

                    countOutterDashes--;

                    countInnerDashes += 2;
                }

                boundary = n / 2;

                countOutterDashes = 1;

                countInnerDashes -= 4;

                for (int i = 1; i <= boundary; i++)
                {
                    if (countInnerDashes < 0)
                    {
                        countInnerDashes = 0;
                    }

                    dashesOutter = new string('-', countOutterDashes);
                    dashesInner = new string('-', countInnerDashes);

                    if (i == boundary)
                    {
                        Console.WriteLine(dashesOutter + '*' + dashesOutter);
                    }
                    else
                    {
                        Console.WriteLine(dashesOutter + '*' + dashesInner + '*' + dashesOutter);
                    }


                    countOutterDashes++;

                    countInnerDashes -= 2;
                }
            }
        }
    }
}
