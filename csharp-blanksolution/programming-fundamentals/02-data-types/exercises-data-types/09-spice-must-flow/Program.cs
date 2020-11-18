using System;

namespace _09_spice_must_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int days = 0;

            int spice = 0;

            if (yield < 100)
            {
                Console.WriteLine(days);

                Console.WriteLine(yield);

                return;
            }

            while (yield >= 100)
            {
                spice += yield - 26;

                yield -= 10;

                days++;
            }

            spice -= 26;

            Console.WriteLine(days);

            Console.WriteLine(spice);
        }
    }
}
