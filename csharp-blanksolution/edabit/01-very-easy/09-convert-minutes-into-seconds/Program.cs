using System;

namespace _09_convert_minutes_into_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var minutes = int.Parse(Console.ReadLine());
            Console.WriteLine(Seconds(minutes));
        }

        public static int Seconds(int minutes) => minutes * 60;
    }
}
