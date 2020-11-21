using System;

namespace _04_konvertor_za_merni_edinici
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            if (input == "mm" && output == "cm")
            {
                Console.WriteLine("{0:F3}", n * 0.1);
            }
            else if (input == "mm" && output == "m")
            {
                Console.WriteLine("{0:F3}", n * 0.001);
            }
            else if (input == "cm" && output == "mm")
            {
                Console.WriteLine("{0:F3}", n * 10);
            }
            else if (input == "cm" && output == "m")
            {
                Console.WriteLine("{0:F3}", n * 0.01);
            }
            else if (input == "m" && output == "mm")
            {
                Console.WriteLine("{0:F3}", n * 1000);
            }
            else if (input == "m" && output == "cm")
            {
                Console.WriteLine("{0:F3}", n * 100);
            }
        }
    }
}
