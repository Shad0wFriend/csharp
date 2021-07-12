using System;

namespace _07_farm_points
{
    class Program
    {
        static void Main(string[] args)
        {
            var wins = int.Parse(Console.ReadLine());
            var draws = int.Parse(Console.ReadLine());
            var losses = int.Parse(Console.ReadLine());
        }

        public static int Points(int wins, int draws, int losses) => wins * 3 + draws;
    }
}
