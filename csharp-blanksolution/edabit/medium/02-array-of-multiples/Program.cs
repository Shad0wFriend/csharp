using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_array_of_multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(' ', MultiplyNumbers(number, length)));
        }

        public static int[] MultiplyNumbers(int number, int length) => Enumerable.Range(1, length).Select(x => x * number).ToArray();
    }
}
