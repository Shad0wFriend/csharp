using System;

namespace _06_calculate_rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            int width = int.Parse(Console.ReadLine());

            int result = RectangleArea(height, width);

            Console.WriteLine(result);
        }

        public static int RectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
