using System;

namespace _09_sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = 1; ; i += 2)
            {
                if (counter == n)
                {
                    Console.WriteLine($"Sum: {sum}");

                    break;
                }

                Console.WriteLine(i);

                sum += i;

                counter++;
            }
        }
    }
}
