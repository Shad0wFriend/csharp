using System;
using System.Globalization;

namespace _01_day_of_week_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input, "d-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
