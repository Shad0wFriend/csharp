using System;

namespace _03_vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double sum = 0;

            if (day == "Friday")
            {
                switch (type)
                {
                    case "Students": sum = 8.45; break;
                    case "Business": sum = 10.90; break;
                    case "Regular": sum = 15; break;
                }
            }
            else if (day == "Saturday")
            {
                switch (type)
                {
                    case "Students": sum = 9.80; break;
                    case "Business": sum = 15.60; break;
                    case "Regular": sum = 20; break;
                }
            }
            else if (day == "Sunday")
            {
                switch (type)
                {
                    case "Students": sum = 10.46; break;
                    case "Business": sum = 16; break;
                    case "Regular": sum = 22.50; break;
                }
            }

            if (group >= 30 && type == "Students")
            {
                double price = sum * 15 / 100;

                sum = (sum - price) * group;

                Console.WriteLine($"Total price: {sum:F2}");
            }
            else if (group >= 100 && type == "Business")
            {
                sum = sum * (group - 10);

                Console.WriteLine($"Total price: {sum:F2}");
            }
            else if (group >= 10 && group <= 20 && type == "Regular")
            {
                double price = sum * 5 / 100;

                sum = (sum - price) * group;

                Console.WriteLine($"Total price: {sum:F2}");
            }
            else
            {
                sum = sum * group;

                Console.WriteLine($"Total price: {sum:F2}");
            }
        }
    }
}
