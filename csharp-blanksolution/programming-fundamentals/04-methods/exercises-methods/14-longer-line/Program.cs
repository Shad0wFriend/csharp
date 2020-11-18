using System;

namespace _14_longer_line
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

            double x4 = double.Parse(Console.ReadLine());

            double y4 = double.Parse(Console.ReadLine());

            double first = Length(x1, y1, x2, y2);

            double second = Length(x3, y3, x4, y4);

            if (first >= second)
            {
                CloserPoint(x1, y1, x2, y2);
            }
            else
            {
                CloserPoint(x3, y3, x4, y4);
            }
        }

        public static double Length(double x1, double y1, double x2, double y2)
        {
            double length = 0;

            double a = Math.Abs(x1) + Math.Abs(x2);

            double b = Math.Abs(y1) + Math.Abs(y2);

            length = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return length;
        }

        public static void CloserPoint(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(Math.Abs(x1), 2) + Math.Pow(Math.Abs(y1), 2));

            double second = Math.Sqrt(Math.Pow(Math.Abs(x2), 2) + Math.Pow(Math.Abs(y2), 2));

            if (first > second)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else if (first == second)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
    }
}
