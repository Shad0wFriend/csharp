using System;

namespace _01_pravoygylnik_ot_10_po_10_zvezdichki
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbol = new string('*', 10);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(symbol);
            }
        }
    }
}
