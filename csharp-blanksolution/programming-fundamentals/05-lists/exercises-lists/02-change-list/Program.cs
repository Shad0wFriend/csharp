using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_change_list
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

                if (commands[0] == "Delete")
                {
                    int number = int.Parse(commands[1]);

                    Delete(numbers, number);
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

        public static void Delete(List<int> numbers, int number)
        {

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == number)
                {
                    numbers.RemoveAt(i);

                    i = -1;
                }
            }
        }

        public static void Insert(List<int> numbers, int number, int index)
        {
            numbers.Insert(index, number);
        }
    }
}
