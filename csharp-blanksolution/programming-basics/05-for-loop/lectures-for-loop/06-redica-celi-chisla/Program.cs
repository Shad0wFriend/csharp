using System;

namespace _06_redica_celi_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int biggest = 0;
            int smallest = 0;
            int previousNumber = 0;
            int n = 0;

            for (int i = 1; i <= countOfNumbers; i++)
            {
                previousNumber = n;

                n = int.Parse(Console.ReadLine());

                if (i == 2)
                {
                    if (previousNumber > n)
                    {
                        biggest = previousNumber;
                        smallest = n;
                    }
                    else
                    {
                        biggest = n;
                        smallest = previousNumber;
                    }
                }
                else
                {
                    if (biggest > n)
                    {

                    }
                    else
                    {
                        biggest = n;
                    }

                    if (smallest < n)
                    {

                    }
                    else
                    {
                        smallest = n;
                    }
                }
            }

            if (countOfNumbers == 1)
            {
                Console.WriteLine("Max number: {0}", n);
                Console.WriteLine("Min number: {0}", n);
            }
            else
            {
                Console.WriteLine("Max number: {0}", biggest);
                Console.WriteLine("Min number: {0}", smallest);
            }
        }
    }
}
