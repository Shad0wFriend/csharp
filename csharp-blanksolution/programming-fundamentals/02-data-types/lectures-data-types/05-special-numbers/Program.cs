using System;

namespace _05_special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                string number = i.ToString();

                for (int k = 0; k <= number.Length - 1; k++)
                {
                    if (n <= 9)
                    {
                        sum += int.Parse(number[k].ToString());

                        if (sum == 5 || sum == 7 || sum == 11)
                        {
                            Console.WriteLine(i + " -> True");
                        }
                        else
                        {
                            Console.WriteLine(i + " -> False");
                        }

                        sum = 0;
                    }
                    else
                    {
                        if (k < number.Length - 1)
                        {
                            sum = int.Parse(number[k].ToString());

                            continue;
                        }

                        sum += int.Parse(number[k].ToString());

                        if (sum == 5 || sum == 7 || sum == 11)
                        {
                            Console.WriteLine(i + " -> True");
                        }
                        else
                        {
                            Console.WriteLine(i + " -> False");
                        }

                        sum = 0;
                    }
                }
            }
        }
    }
}
