using System;

namespace _05_kvadratna_ramka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string dashes = "";

            for (int i = 1; i <= n - 2; i++)
            {
                dashes += "- ";
            }

            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.WriteLine("+ " + dashes + '+');
                }
                else
                {
                    Console.WriteLine("| " + dashes + '|');
                }
            }
        }
    }
}
