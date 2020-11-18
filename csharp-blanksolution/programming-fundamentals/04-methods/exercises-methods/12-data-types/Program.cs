using System;

namespace _12_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string number = Console.ReadLine();

            switch (input)
            {
                case "int": Console.WriteLine(Int(int.Parse(number))); break;
                case "real": Console.WriteLine($"{Double(double.Parse(number)):F2}"); break;
                case "string": Console.WriteLine(String(number)); break;
            }
        }

        public static int Int(int number)
        {
            return number * 2;
        }

        public static double Double(double number)
        {
            return number * 1.5;
        }

        public static string String(string number)
        {
            return "$" + number + "$";
        }
    }
}
