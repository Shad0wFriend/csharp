using System;

namespace _02_how_edabit_works
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = True();
            Console.WriteLine(result);
        }

        public static bool True() => true;
    }
}
