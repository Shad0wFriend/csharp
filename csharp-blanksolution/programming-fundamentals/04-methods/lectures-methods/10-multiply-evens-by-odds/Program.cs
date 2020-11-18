using System;

namespace _10_multiply_evens_by_odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            number = Math.Abs(number);

            string n = number.ToString();

            int even = Even(n);

            int odd = Odd(n);

            int result = Result(even, odd);

            Console.WriteLine(result);

        }

        public static int Even(string n)
        {
            int even = 0;

            foreach (char symbol in n)
            {
                int number = int.Parse(symbol.ToString());

                if (number % 2 == 0)
                {
                    even += number;
                }
            }

            return even;
        }

        public static int Odd(string n)
        {
            int odd = 0;

            foreach (char symbol in n)
            {
                int number = int.Parse(symbol.ToString());

                if (number % 2 == 1)
                {
                    odd += number;
                }
            }

            return odd;
        }

        public static int Result(int even, int odd)
        {
            return even * odd;
        }
    }
}
