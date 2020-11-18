using System;

namespace _01_convert_meters_to_kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(distance * 0.001):F2}");
        }
    }
}
