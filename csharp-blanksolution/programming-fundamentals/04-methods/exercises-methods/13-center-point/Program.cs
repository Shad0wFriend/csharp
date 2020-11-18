using System;

namespace _13_center_point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());

            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());

            double y2 = double.Parse(Console.ReadLine());

            double first = Distance(x1, y1);

            double second = Distance(x2, y2);

            if (first > second)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else if (first == second)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        public static double Distance(double x, double y)
        {
            x = Math.Abs(x);

            y = Math.Abs(y);

            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return distance;
        }
    }
}
