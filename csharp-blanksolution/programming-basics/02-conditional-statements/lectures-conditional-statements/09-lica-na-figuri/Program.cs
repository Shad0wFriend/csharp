using System;

namespace _09_lica_na_figuri
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"{side * side:F3}");
            }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", a * b);
            }
            else if (type == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", Math.PI * r * r);
            }
            else
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", side * height / 2);
            }
        }
    }
}
