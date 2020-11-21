using System;

namespace _05_fabrika_za_biskviti
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfBatches = int.Parse(Console.ReadLine());

            int counter = 0;

            bool isSugar = false;
            bool isFlour = false;
            bool isEggs = false;

            while (true)
            {
                string ingrediant = Console.ReadLine();

                if (ingrediant == "Bake!")
                {
                    if (isFlour == true && isSugar == true && isEggs == true)
                    {
                        counter++;

                        Console.WriteLine($"Baking batch number {counter}...");

                        isFlour = false;
                        isSugar = false;
                        isEggs = false;
                    }
                    else
                    {
                        Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                    }
                }

                if (counter == countOfBatches)
                {
                    break;
                }

                switch (ingrediant)
                {
                    case "flour": isFlour = true; break;
                    case "eggs": isEggs = true; break;
                    case "sugar": isSugar = true; break;
                }
            }
        }
    }
}
