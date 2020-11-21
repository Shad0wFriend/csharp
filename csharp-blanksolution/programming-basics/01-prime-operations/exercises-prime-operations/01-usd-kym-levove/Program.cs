using System;

namespace _01_usd_kym_levove
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolars = double.Parse(Console.ReadLine());
            double leva = dolars * 1.79549;

            Console.WriteLine($"{leva:F2}");
        }
    }
}
