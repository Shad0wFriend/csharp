using System;

namespace _01_proverka_za_otlichna_ocenka
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50 && grade <= 6)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
