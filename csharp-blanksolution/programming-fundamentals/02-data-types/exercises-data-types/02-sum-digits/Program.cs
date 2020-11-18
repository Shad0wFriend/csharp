using System;

namespace _02_sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            foreach (char symbol in number)
            {
                int digit = int.Parse(symbol.ToString());

                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
