using System;

namespace _08_the_farm_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var chickens = int.Parse(Console.ReadLine());
            var cows = int.Parse(Console.ReadLine());
            var pigs = int.Parse(Console.ReadLine());
        }

        public static int Legs(int chickens, int cows, int pigs) => chickens * 2 + cows * 4 + pigs * 4;
    }
}
