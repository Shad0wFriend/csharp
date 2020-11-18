using System;

namespace _11_sort_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double max = 0;
            double middle = 0;
            double smallest = 0;

            if (a >= b && a >= c)
            {
                max = a;

                smallest = Math.Min(b, c);

                if (smallest == b)
                {
                    middle = Math.Max(smallest, c);
                }
                else
                {
                    middle = Math.Max(smallest, b);
                }
            }
            else if (b >= a && b >= c)
            {
                max = b;

                smallest = Math.Min(a, c);

                if (smallest == a)
                {
                    middle = Math.Max(smallest, c);
                }
                else
                {
                    middle = Math.Max(smallest, a);
                }
            }
            else
            {
                max = c;

                smallest = Math.Min(a, b);

                if (smallest == a)
                {
                    middle = Math.Max(smallest, b);
                }
                else
                {
                    middle = Math.Max(smallest, a);
                }
            }

            Console.WriteLine(max);
            Console.WriteLine(middle);
            Console.WriteLine(smallest);
        }
    }
}
