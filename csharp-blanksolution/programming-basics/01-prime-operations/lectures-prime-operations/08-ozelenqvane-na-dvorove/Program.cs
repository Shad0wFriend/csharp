using System;

namespace _08_ozelenqvane_na_dvorove
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double fullCost = meters * 7.61;
            double discount = fullCost * 0.18;

            Console.WriteLine($"The final price is: {fullCost - discount:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
