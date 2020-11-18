using System;

namespace _09_palindrome_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (IsPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                input = Console.ReadLine();
            }
        }

        public static bool IsPalindrome(string input)
        {
            int middle = input.Length / 2;

            int counter = input.Length - 1;

            bool[] result = new bool[middle + 1];

            for (int i = 0; i <= middle; i++)
            {
                if (input[i] == input[counter])
                {
                    result[i] = true;
                }
                else
                {
                    return false;
                }

                counter--;
            }

            return true;
        }
    }
}
