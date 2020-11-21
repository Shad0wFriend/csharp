using System;

namespace _01_sumirane_na_sekundi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int time = a + b + c;

            if (time < 60)
            {
                Console.WriteLine($"0:{time:D2}");
            }
            else
            {
                int hours = time / 60;
                int minutes = time % 60;

                Console.WriteLine($"{hours}:{minutes:D2}");
            }
        }
    }
}
