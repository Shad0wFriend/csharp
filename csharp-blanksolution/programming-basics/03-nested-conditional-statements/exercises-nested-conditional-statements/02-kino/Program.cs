using System;

namespace _02_kino
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int coloms = int.Parse(Console.ReadLine());

            int spectators = rows * coloms;

            if (projection == "Premiere")
            {
                double profit = spectators * 12;

                Console.WriteLine("{0:F2}", profit);
            }
            else if (projection == "Normal")
            {
                double profit = spectators * 7.5;

                Console.WriteLine("{0:F2}", profit);
            }
            else
            {
                double profit = spectators * 5;

                Console.WriteLine("{0:F2}", profit);
            }
        }
    }
}
