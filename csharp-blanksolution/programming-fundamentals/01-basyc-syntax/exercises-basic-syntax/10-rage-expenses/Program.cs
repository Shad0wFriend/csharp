using System;

namespace _10_rage_expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double expenses = 0;

            int counter = 0;

            for (int i = 0; i <= lostGames; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        expenses += headset;
                    }

                    if (i % 3 == 0)
                    {
                        expenses += mouse;
                    }

                    if (i % 6 == 0)
                    {
                        expenses += keyboard;

                        counter++;
                    }

                    if (counter % 2 == 0 && counter != 0)
                    {
                        expenses += display;

                        counter = 0;
                    }
                }
            }

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
