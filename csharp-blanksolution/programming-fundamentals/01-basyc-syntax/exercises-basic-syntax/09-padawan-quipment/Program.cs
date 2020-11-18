using System;

namespace _09_padawam_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaber = double.Parse(Console.ReadLine());
            double robe = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());

            double percentage = Math.Ceiling(students + (students * 0.1));

            double amountOfSabers = percentage * lightsaber;

            double amountOfRobes = students * robe;

            double amountOfBelts = 0;

            if (students / 6 > 0)
            {
                int bonus = students / 6;

                amountOfBelts = (students - bonus) * belt;
            }
            else
            {
                amountOfBelts = students * belt;
            }

            double total = amountOfSabers + amountOfBelts + amountOfRobes;

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(total - money):F2}lv more.");
            }
        }
    }
}
