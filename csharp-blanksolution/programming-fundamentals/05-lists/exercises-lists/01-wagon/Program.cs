using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_wagon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int capacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(' ');

                if (commands[0] == "Add")
                {
                    int number = int.Parse(commands[1]);

                    Add(numbers, number);
                }
                else
                {
                    int amount = int.Parse(commands[0]);

                    Passangers(numbers, amount, capacity);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        public static void Add(List<int> numbers, int number)
        {
            numbers.Add(number);
        }

        public static void Passangers(List<int> numbers, int amount, int capacity)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != capacity)
                {
                    if (numbers[i] + amount <= capacity)
                    {
                        numbers[i] += amount;

                        break;
                    }
                }
            }
        }
    }
}
