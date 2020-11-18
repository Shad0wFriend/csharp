using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_list_manipulation_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            bool isChanged = false;

            while (input != "end")
            {
                string[] commands = input.Split(' ');

                if (commands[0] == "Add")
                {
                    int number = int.Parse(commands[1]);

                    Add(numbers, number);

                    isChanged = true;
                }
                else if (commands[0] == "Remove")
                {
                    int number = int.Parse(commands[1]);

                    Remove(numbers, number);

                    isChanged = true;
                }
                else if (commands[0] == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);

                    RemoveAt(numbers, index);

                    isChanged = true;
                }
                else if (commands[0] == "Insert")
                {
                    int number = int.Parse(commands[1]);

                    int index = int.Parse(commands[2]);

                    Insert(numbers, number, index);

                    isChanged = true;
                }
                else if (commands[0] == "Contains")
                {
                    int number = int.Parse(commands[1]);

                    if (Contains(numbers, number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (commands[0] == "PrintEven")
                {
                    PrintEven(numbers);
                }
                else if (commands[0] == "PrintOdd")
                {
                    PrintOdd(numbers);
                }
                else if (commands[0] == "GetSum")
                {
                    GetSum(numbers);
                }
                else if (commands[0] == "Filter")
                {
                    string condition = commands[1];

                    int number = int.Parse(commands[2]);

                    Filter(numbers, condition, number);
                }


                input = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
        }

        public static void Add(List<int> numbers, int number)
        {
            numbers.Add(number);
        }

        public static void Remove(List<int> numbers, int number)
        {
            numbers.Remove(number);
        }

        public static void RemoveAt(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }

        public static void Insert(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
        }

        public static bool Contains(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                return true;
            }

            return false;
        }

        public static void PrintEven(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        public static void PrintOdd(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            Console.WriteLine();
        }

        public static void GetSum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        public static void Filter(List<int> numbers, string condition, int number)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                switch (condition)
                {
                    case "<":
                        if (numbers[i] < number)
                        {
                            Console.Write(numbers[i] + " ");
                        }

                        break;
                    case ">":
                        if (numbers[i] > number)
                        {
                            Console.Write(numbers[i] + " ");
                        }

                        break;
                    case "<=":
                        if (numbers[i] <= number)
                        {
                            Console.Write(numbers[i] + " ");
                        }

                        break;
                    case ">=":
                        if (numbers[i] >= number)
                        {
                            Console.Write(numbers[i] + " ");
                        }

                        break;
                }
            }

            Console.WriteLine();
        }
    }
}
