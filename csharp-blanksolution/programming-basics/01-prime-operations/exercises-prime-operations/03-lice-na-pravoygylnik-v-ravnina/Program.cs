using System;

namespace _03_lice_na_pravoygylnik_v_ravnina
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double oneSide = Math.Abs(x1 - x2);
            double otherSide = Math.Abs(y1 - y2);

            Console.WriteLine($"{oneSide * otherSide:F2}");
            Console.WriteLine($"{2 * (oneSide + otherSide):F2}");
        }
    }
}
