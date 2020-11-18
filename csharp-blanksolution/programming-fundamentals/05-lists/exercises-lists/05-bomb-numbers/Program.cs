using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_bomb_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> data = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int bomb = data[0];

            int power = data[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int index = DetonateLeft(numbers, i, power);

                    DetonateRight(numbers, index, power);

                    i = -1;
                }
            }

            int result = Sum(numbers);

            Console.WriteLine(result);
        }

        public static int DetonateLeft(List<int> numbers, int index, int power)
        {
            int position = 0;

            int counter = 0;

            for (int i = index; ; i--)
            {
                if (counter == power + 1)
                {
                    break;
                }

                if (i < 0)
                {
                    break;
                }

                numbers.RemoveAt(i);

                counter++;

                position = i;
            }

            return position;
        }

        public static void DetonateRight(List<int> numbers, int index, int power)
        {
            int counter = 1;

            for (int i = index; ;)
            {
                if (counter == power + 1)
                {
                    break;
                }

                if (i >= numbers.Count)
                {
                    break;
                }

                numbers.RemoveAt(i);

                counter++;
            }
        }

        public static int Sum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
