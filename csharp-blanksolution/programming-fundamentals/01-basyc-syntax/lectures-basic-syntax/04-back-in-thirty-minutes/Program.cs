using System;

namespace _04_back_int_thirty_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int afterTime = minutes + 30;

            if (afterTime >= 60)
            {
                hours++;

                minutes = afterTime - 60;
            }
            else
            {
                minutes += 30;
            }

            if (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
