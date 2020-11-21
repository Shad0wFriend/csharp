using System;

namespace _01_kombinacii
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i <= n; i++)
            {
                for (int a = 0; a <= n; a++)
                {
                    for (int b = 0; b <= n; b++)
                    {
                        for (int c = 0; c <= n; c++)
                        {
                            for (int d = 0; d <= n; d++)
                            {
                                if (i + a + b + c + d == n)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
