using System;
using System.Linq;

namespace _10_softuni_course_planning
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            if (true) { Console.WriteLine('a'); }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
