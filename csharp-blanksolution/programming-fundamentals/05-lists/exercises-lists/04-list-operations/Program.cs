using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_list_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split(' ');

                if (commands[0] == "Add")
                {
                    int number = int.Parse(commands[1]);

                    Add(numbers, number);
                }
                else if (commands[0] == "Insert")
                {
                    int number = int.Parse(commands[1]);

                    int index = int.Parse(commands[2]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");

                        input = Console.ReadLine();

                        continue;
                    }

                    Insert(numbers, number, index);
                }
                else if (commands[0] == "Remove")
                {
                    int index = int.Parse(commands[1]);

                    if (index >= numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");

                        input = Console.ReadLine();

                        continue;
                    }

                    Remove(numbers, index);
                }
                else if (commands[0] == "Shift")
                {
                    int rotations = int.Parse(commands[2]);

                    if (commands[1] == "left")
                    {
                        ShiftLeft(numbers, rotations);
                    }
                    else if (commands[1] == "right")
                    {
                        ShiftRight(numbers, rotations);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
        }

        public static void Add(List<int> numbers, int number)
        {
            numbers.Add(number);
        }

        public static void Insert(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
        }

        public static void Remove(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        public static void ShiftLeft(List<int> numbers, int rotations)
        {
            int lastNumber = numbers[0];

            for (int i = 0; i < rotations; i++)
            {
                for (int k = 0; k < numbers.Count; k++)
                {
                    if (k + 1 >= numbers.Count)
                    {
                        break;
                    }

                    numbers[k] = numbers[k + 1];
                }

                numbers[numbers.Count - 1] = lastNumber;
                lastNumber = numbers[0];
            }
        }

        public static void ShiftRight(List<int> numbers, int rotations)
        {
            int firstNumber = numbers[numbers.Count - 1];

            for (int i = 0; i < rotations; i++)
            {
                for (int k = numbers.Count - 1; k >= 0; k--)
                {
                    if (k - 1 < 0)
                    {
                        break;
                    }

                    numbers[k] = numbers[k - 1];
                }

                numbers[0] = firstNumber;

                firstNumber = numbers[numbers.Count - 1];
            }
        }
    }
}
