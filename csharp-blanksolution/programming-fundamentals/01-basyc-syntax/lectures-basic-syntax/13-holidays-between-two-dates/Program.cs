using System;
using System.Globalization;

namespace _13_holidays_between_two_dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
            //DateTime today = DateTime.Today;
            //DateTime now = DateTime.Now;
            //DateTime date = new DateTime(2019, 11, 10, 11, 28, 23);


            string start = Console.ReadLine();

            string digit = "";

            foreach (char symbol in start)
            {
                if (symbol != '.')
                {
                    digit += symbol;
                }
                else
                {
                    break;
                }
            }

            DateTime startDate;

            if (digit.Length == 2)
            {
                startDate = DateTime.ParseExact(start, "dd.M.yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                startDate = DateTime.ParseExact(start, "d.M.yyyy", CultureInfo.InvariantCulture);
            }

            string end = Console.ReadLine();

            digit = "";

            foreach (char symbol in end)
            {
                if (symbol != '.')
                {
                    digit += symbol;
                }
                else
                {
                    break;
                }
            }

            DateTime endDate;

            if (digit.Length == 2)
            {
                endDate = DateTime.ParseExact(end, "dd.M.yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                endDate = DateTime.ParseExact(end, "d.M.yyyy", CultureInfo.InvariantCulture);
            }

            int holidaysCount = 0;

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }

            Console.WriteLine(holidaysCount);
        }
    }
}
