using System;

namespace _05_vreme_plus_15_sekundi
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int newTime = minutes + 15;

            if (newTime >= 60)
            {
                if (hours == 23)
                {
                    Console.WriteLine("{0}:{1:D2}", 0, newTime - 60);
                }
                else
                {
                    hours += 1;

                    Console.WriteLine("{0}:{1:D2}", hours, newTime - 60);
                }
            }
            else
            {
                Console.WriteLine("{0}:{1:D2}", hours, newTime);
            }
        }
    }
}
