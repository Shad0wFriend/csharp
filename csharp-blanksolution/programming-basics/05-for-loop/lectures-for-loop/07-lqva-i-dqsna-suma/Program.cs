using System;

namespace _07_lqva_i_dqsna_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < 2 * countOfNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (i < countOfNumbers)
                {
                    leftSum += n;
                }
                else
                {
                    rightSum += n;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int difference = Math.Abs(leftSum - rightSum);

                Console.WriteLine("No, diff = " + difference);
            }
        }
    }
}
