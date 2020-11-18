using System;

namespace _12_english_name_of_the_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string result = LastDigit(n);

            Console.WriteLine(result);
        }

        static string LastDigit(int n)
        {
            int lastDigit = n % 10;

            string name = "";

            switch (lastDigit)
            {
                case 0: name = "zero"; break;
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seventh"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
            }

            return name;
        }
    }
}
