using System;

namespace _06_lice_i_perimetyr_na_kryg
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            double perimetyr = Math.PI * r * r;
            double area = Math.PI * 2 * r;

            Console.WriteLine($"{Math.PI * r * r:F2}");
            Console.WriteLine($"{perimetyr:F2}");

            Console.WriteLine("{0:F2}", area);
        }
    }
}
