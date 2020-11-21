using System;

namespace _05_naj_golqmo_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int temp = 0;
            int biggest = 0;

            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (counter > 1)
                {
                    if (counter == 2)
                    {
                        if (temp > number)
                        {
                            biggest = temp;
                        }
                        else
                        {
                            biggest = number;
                        }
                    }
                    else if (counter > 2)
                    {
                        if (biggest > number)
                        {

                        }
                        else
                        {
                            biggest = number;
                        }
                    }
                }

                if (counter == n)
                {
                    if (n == 1)
                    {
                        Console.WriteLine(number);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(biggest);
                        break;
                    }
                }

                if (counter == 1)
                {
                    temp = number;
                }

                counter++;
            }
        }
    }
}
