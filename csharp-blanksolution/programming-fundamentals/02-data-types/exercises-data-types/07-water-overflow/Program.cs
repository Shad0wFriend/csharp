using System;

namespace _07_water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int counter = 1;
            int capacity = 255;
            int quantity = 0;

            int water = 0;

            while (counter <= countOfNumbers)
            {
                water = int.Parse(Console.ReadLine());

                if (water > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= water;

                    quantity += water;
                }

                counter++;
            }

            Console.WriteLine(quantity);
        }
    }
}
