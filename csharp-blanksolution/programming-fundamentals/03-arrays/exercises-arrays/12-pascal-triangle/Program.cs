using System;
using System.Globalization;

namespace _12_pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] current = new int[1];

            int[] previous = new int[2];

            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(1);
                Console.WriteLine(1 + " " + 1);
            }

            for (int i = 3; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    previous = new int[i];

                    for (int k = 0; k < i; k++)
                    {
                        if (k - 1 < 0)
                        {
                            previous[k] = 1;
                        }
                        else if (k + 1 >= current.Length)
                        {
                            previous[k] = current[k - 1] + 1;
                        }
                        else
                        {
                            previous[k] = current[k - 1] + current[k];
                        }

                        if (k == 0 || k == i - 1)
                        {
                            previous[k] = 1;
                        }

                        Console.Write(previous[k] + " ");
                    }
                }
                else
                {
                    current = new int[i];

                    for (int k = 0; k < i; k++)
                    {
                        if (current.Length == 3 && k == 1)
                        {
                            current[k] = 2;
                        }

                        if (k == 0 || k == i - 1)
                        {
                            current[k] = 1;
                        }

                        if (current.Length > 3)
                        {
                            if (k - 1 < 0)
                            {
                                current[k] = 1;
                            }
                            else if (k + 1 >= previous.Length)
                            {
                                current[k] = previous[k - 1] + 1;
                            }
                            else
                            {
                                current[k] = previous[k - 1] + previous[k];
                            }

                            if (k == 0 || k == i - 1)
                            {
                                current[k] = 1;
                            }
                        }

                        Console.Write(current[k] + " ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
