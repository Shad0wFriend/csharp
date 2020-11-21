using System;

namespace _06_naj_malko_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            int temp = 0;
            int smallest = 0;

            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (counter > 1)
                {
                    if (counter == 2)
                    {
                        if (temp > number)
                        {
                            smallest = number;
                        }
                        else
                        {
                            smallest = temp;
                        }
                    }
                    else if (counter > 2)
                    {
                        if (smallest < number)
                        {

                        }
                        else
                        {
                            smallest = number;
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
                        Console.WriteLine(smallest);
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
