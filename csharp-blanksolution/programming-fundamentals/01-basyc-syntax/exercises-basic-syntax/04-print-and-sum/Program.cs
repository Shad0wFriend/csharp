using System;

namespace _04_print_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = 0;
            string sequence = "";

            for (int i = a; i <= b; i++)
            {
                sum += i;

                if (i == b)
                {
                    sequence += i;
                }
                else
                {
                    sequence += i + " ";
                }
            }

            Console.WriteLine(sequence);
            Console.WriteLine("Sum: " + sum);
        }
    }
}
