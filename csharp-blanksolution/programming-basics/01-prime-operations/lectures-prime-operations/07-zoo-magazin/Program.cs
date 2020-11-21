using System;

namespace _07_zoo_magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());

            double costForDogs = numberOfDogs * 2.50;
            int costForOther = numberOfOtherAnimals * 4;

            Console.WriteLine($"{costForDogs + costForOther:F2} lv.");
        }
    }
}
