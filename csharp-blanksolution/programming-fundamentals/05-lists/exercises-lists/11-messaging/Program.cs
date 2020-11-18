using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string text = Console.ReadLine();

            int sum = 0;

            int counter = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];

                while (number > 0)
                {
                    sum += number % 10;

                    number = number / 10;
                }

                for (int k = 0; k <= text.Length; k++)
                {
                    if (k == text.Length)
                    {
                        k = -1;

                        continue;
                    }

                    if (counter == sum)
                    {
                        Console.Write(text[k]);

                        string tmp = text.Remove(k, 1);

                        text = tmp;

                        break;
                    }

                    counter++;
                }

                sum = 0;

                counter = 0;
            }

            Console.WriteLine();
        }
    }
}
