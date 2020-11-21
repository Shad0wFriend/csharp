using System;

namespace _02_pravoygylnik_ot_n_po_n_zvezdichki
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string symbol = new string('*', n);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(symbol);
            }
        }
    }
}
