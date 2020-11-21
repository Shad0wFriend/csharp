using System;

namespace _02_sgrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfFloors = int.Parse(Console.ReadLine());
            int countOfRooms = int.Parse(Console.ReadLine());

            for (int i = countOfFloors; i >= 1; i--)
            {
                for (int a = 0; a < countOfRooms; a++)
                {
                    if (i == countOfFloors)
                    {
                        Console.Write($"L{i}{a} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{a} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{a} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
