using System;

namespace _11_manipulation_table_second_version
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {i * n}");
            }

            if (multiplier > 10)
            {
                Console.WriteLine($"{n} X {multiplier} = {multiplier * n}");
            }
        }
    }
}
