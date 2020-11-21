using System;

namespace _08_chetna_nechetna_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 1; i <= countOfNumbers; i++)
            {
                if (i % 2 == 0)
                {
                    int n = int.Parse(Console.ReadLine());

                    evenSum += n;
                }
                else
                {
                    int n = int.Parse(Console.ReadLine());

                    oddSum += n;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                int difference = Math.Abs(evenSum - oddSum);

                Console.WriteLine("No");
                Console.WriteLine("Diff = " + difference);
            }
        }
    }
}
