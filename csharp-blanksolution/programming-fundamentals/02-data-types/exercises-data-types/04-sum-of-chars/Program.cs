using System;

namespace _04_sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfChars = int.Parse(Console.ReadLine());

            int counter = 1;
            int sum = 0;

            while (counter <= countOfChars)
            {
                char symbol = char.Parse(Console.ReadLine());

                sum += symbol;

                counter++;
            }

            Console.WriteLine("The sum equals: " + sum);
        }
    }
}
