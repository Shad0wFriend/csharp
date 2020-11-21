using System;

namespace _03_pochivka
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVacation = double.Parse(Console.ReadLine());
            double presentMoney = double.Parse(Console.ReadLine());
            int counter = 0;
            int counterForSpending = 0;
            string task = "";
            string previousTask = "";

            while (true)
            {
                previousTask = task;

                if (previousTask == "spend")
                {
                    counterForSpending++;
                }
                else
                {
                    counterForSpending = 0;
                }

                if (counterForSpending == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(counter);
                    break;
                }

                if (presentMoney >= moneyForVacation)
                {
                    Console.WriteLine($"You saved the money for {counter} days.");
                    break;
                }

                task = Console.ReadLine();

                double money = double.Parse(Console.ReadLine());

                if (task == "spend")
                {
                    if (money > presentMoney)
                    {
                        presentMoney = 0;
                    }
                    else
                    {
                        presentMoney -= money;
                    }
                }
                else if (task == "save")
                {
                    presentMoney += money;
                }

                counter++;
            }
        }
    }
}
