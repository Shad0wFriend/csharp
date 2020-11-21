using System;

namespace _01_chislo_v_diapazona
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());

                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine("The number is: " + n);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
