using System;

namespace _12_magazin_za_detski_igrachki
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double costPuzzles = numberOfPuzzles * 2.60;
            double costDolls = numberOfDolls * 3;
            double costTeddyBears = numberOfTeddyBears * 4.10;
            double costMinions = numberOfMinions * 8.20;
            double costTrucks = numberOfTrucks * 2;

            double profit = costPuzzles + costDolls + costTeddyBears + costMinions + costTrucks;
            double toys = numberOfPuzzles + numberOfDolls + numberOfTeddyBears + numberOfMinions + numberOfTrucks;

            if (toys >= 50)
            {
                double discount = profit * 25 / 100;
                double tax = (profit - discount) * 10 / 100;

                profit = profit - discount - tax;
            }
            else
            {
                double tax = profit * 10 / 100;
                profit = profit - tax;
            }

            if (profit >= cost)
            {
                Console.WriteLine($"Yes! {profit - cost:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {cost - profit:F2} lv needed.");
            }
        }
    }
}
