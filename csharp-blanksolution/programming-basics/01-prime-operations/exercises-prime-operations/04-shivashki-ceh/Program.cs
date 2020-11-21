using System;

namespace _04_shivashki_ceh
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTables = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double cover = numberOfTables * (lenght + 0.6) * (width + 0.6);
            double otherCover = (lenght / 2) * (lenght / 2) * numberOfTables;

            double usd = (cover * 7) + (otherCover * 9);
            double lv = usd * 1.85;

            Console.WriteLine($"{usd:F2} USD");
            Console.WriteLine($"{lv:F2} BGN");
        }
    }
}
