using System;

namespace _02_piramida_ot_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int k = 1; k <= rows; k++)
                {
                    if (current > n)
                    {
                        break;
                    }

                    Console.Write(current + " ");

                    current++;
                }

                Console.WriteLine();

                if (current > n)
                {
                    break;
                }
            }
        }
    }
}
