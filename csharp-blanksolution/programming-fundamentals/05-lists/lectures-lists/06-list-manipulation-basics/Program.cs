using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_list_manipulation_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(' ');

                if (commands[0] == "Add")
                {
                    int number = int.Parse(commands[1]);

                    Add(numbers, number);
                }
                else if (commands[0] == "Remove")
                {
                    int number = int.Parse(commands[1]);

                    Remove(numbers, number);
                }
                else if (commands[0] == "RemoveAt")
                {
                    int index = int.Parse(commands[1]);

                    RemoveAt(numbers, index);
                }
                else if (commands[0] == "Insert")
                {
                    int number = int.Parse(commands[1]);

                    int index = int.Parse(commands[2]);

                    Insert(numbers, number, index);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', numbers));
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
    }
}
