using System;

namespace _04_convert_age_to_days
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            Console.WriteLine(Days(years));
        }

        public static int Days(int years) => years * 365;
    }
}
