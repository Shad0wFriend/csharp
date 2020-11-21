using System;

namespace _03_kvadrat_ot_zvezdichki
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string symbol = "";

            for (int i = 0; i < n; i++)
            {
                symbol += "* ";
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(symbol);
            }
        }
    }
}
