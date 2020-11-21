using System;

namespace _02_element_raven_na_sumata_na_ostanalite
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int sum = 0;

            for (int i = 0; i < countOfNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                sum += n;

                if (biggest < n)
                {
                    biggest = n;
                }
            }

            sum -= biggest;

            if (sum == biggest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                int difference = Math.Abs(sum - biggest);

                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }
        }
    }
}
