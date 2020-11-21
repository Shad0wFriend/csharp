using System;

namespace _03_redica_chisla_2k_plus_edno
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = a;

            while (true)
            {
                if (a == n)
                {
                    Console.WriteLine(n);
                    break;
                }
                else
                {
                    Console.WriteLine(a);

                    b = 2 * a + 1;
                    a = b;
                }

                if (a > n)
                {
                    break;
                }
            }
        }
    }
}
