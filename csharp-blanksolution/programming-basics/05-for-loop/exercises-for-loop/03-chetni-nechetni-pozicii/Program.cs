using System;

namespace _03_chetni_nechetni_pozicii
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            double evenBiggest = double.MinValue;
            double evenSmallest = double.MaxValue;
            double oddBiggest = double.MinValue;
            double oddSmallest = double.MaxValue;
            double evenAverage = 0;
            double oddAverage = 0;

            for (int i = 1; i <= countOfNumbers; i++)
            {
                if (i % 2 == 0)
                {
                    double n = double.Parse(Console.ReadLine());

                    evenAverage += n;

                    if (evenBiggest < n)
                    {
                        evenBiggest = n;
                    }

                    if (evenSmallest > n)
                    {
                        evenSmallest = n;
                    }
                }
                else
                {
                    double n = double.Parse(Console.ReadLine());

                    oddAverage += n;

                    if (oddBiggest < n)
                    {
                        oddBiggest = n;
                    }

                    if (oddSmallest > n)
                    {
                        oddSmallest = n;
                    }
                }
            }

            if (countOfNumbers == 0)
            {
                Console.WriteLine($"OddSum={oddAverage:F2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenAverage:F2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (countOfNumbers == 1)
            {
                Console.WriteLine($"OddSum={oddAverage:F2},");
                Console.WriteLine($"OddMin={oddSmallest:F2},");
                Console.WriteLine($"OddMax={oddBiggest:F2},");
                Console.WriteLine($"EvenSum={evenAverage:F2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddAverage:F2},");
                Console.WriteLine($"OddMin={oddSmallest:F2},");
                Console.WriteLine($"OddMax={oddBiggest:F2},");
                Console.WriteLine($"EvenSum={evenAverage:F2},");
                Console.WriteLine($"EvenMin={evenSmallest:F2},");
                Console.WriteLine($"EvenMax={evenBiggest:F2}");
            }
        }
    }
}
