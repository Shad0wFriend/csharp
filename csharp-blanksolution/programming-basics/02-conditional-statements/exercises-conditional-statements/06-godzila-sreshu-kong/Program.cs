using System;

namespace _06_godzila_sreshu_kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForStatist = double.Parse(Console.ReadLine());

            double costForStatists;

            if (statists >= 150)
            {
                double discount = priceForStatist * 0.1;
                priceForStatist -= discount;
                costForStatists = statists * priceForStatist;
            }
            else
            {
                costForStatists = statists * priceForStatist;
            }

            double decor = budget * 0.1;

            if (decor + costForStatists > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:F2} leva more.", decor + costForStatists - budget);
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:F2} leva left.", budget - (decor + costForStatists));
            }
        }
    }
}
