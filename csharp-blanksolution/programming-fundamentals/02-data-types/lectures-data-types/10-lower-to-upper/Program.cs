using System;

namespace _10_lower_to_upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            int symbolNumber = symbol;

            if (symbolNumber >= 97 && symbolNumber <= 122)
            {
                Console.WriteLine("lower-case");
            }
            else if (symbolNumber >= 65 && symbolNumber <= 90)
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
