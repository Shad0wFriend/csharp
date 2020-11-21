using System;

namespace _01_tochka_vyrhu_stranata_na_pravoygylnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            if ((y3 > y1 && y3 < y2) && (x3 == x1 || x3 == x2))
            {
                Console.WriteLine("Border");
            }
            else if ((y3 == y1 || y3 == y2) && (x3 >= x1 && x3 <= x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
