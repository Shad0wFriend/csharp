using System;

namespace _08_izlet
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int quota = 0;
            int countOfFishes = 0;
            string fish = "";
            double profit = 0;
            double debt = 0;
            double tax = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                {
                    break;
                }

                if (counter == 0)
                {
                    quota = int.Parse(input);

                    counter++;

                    continue;
                }
                else if (counter == 1)
                {
                    fish = input;

                    countOfFishes++;

                    counter++;

                    continue;
                }
                else if (counter == 2)
                {
                    double killograms = double.Parse(input);

                    foreach (char item in fish)
                    {
                        tax += item / killograms;
                    }

                    counter = 1;
                }

                if (countOfFishes % 3 == 0)
                {
                    profit += tax;
                }
                else
                {
                    debt += tax;
                }

                if (countOfFishes == quota)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }

                tax = 0;
            }

            if (profit > debt)
            {
                profit = Math.Abs(profit - debt);

                Console.WriteLine($"Lyubo's profit from {countOfFishes} fishes is {profit:F2} leva.");
            }
            else
            {
                debt = Math.Abs(debt - profit);

                Console.WriteLine($"Lyubo lost {debt:F2} leva today.");
            }
        }
    }
}
