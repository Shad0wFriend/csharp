using System;

namespace _03_lqtno_obleklo
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();

            if (partOfTheDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine("It's {0} degrees, get your Sweatshirt and Sneakers.", degrees);
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else
                {
                    Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                }
            }
            else if (partOfTheDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine("It's {0} degrees, get your T-Shirt and Sandals.", degrees);
                }
                else
                {
                    Console.WriteLine("It's {0} degrees, get your Swim Suit and Barefoot.", degrees);
                }
            }
            else
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
                else
                {
                    Console.WriteLine("It's {0} degrees, get your Shirt and Moccasins.", degrees);
                }
            }
        }
    }
}
