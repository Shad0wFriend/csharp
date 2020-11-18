using System;

namespace _10_top_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            for (int i = 1; i <= end; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool IsTopNumber(int i)
        {
            string number = i.ToString();

            int sum = 0;

            foreach (char symbol in number)
            {
                sum += symbol;
            }

            bool isOdd = false;

            foreach (char symbol in number)
            {
                if (symbol % 2 == 1)
                {
                    isOdd = true;

                    break;
                }
            }

            if (sum % 8 == 0 && isOdd == true)
            {
                return true;
            }

            return false;
        }
    }
}
