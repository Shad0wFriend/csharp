using System;

namespace _03_area_of_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(a, h));
        }

        public static double Area(double a, double h) => (a * h) / 2;
    }
}
