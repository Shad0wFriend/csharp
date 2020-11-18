using System;

namespace _16_multiplication_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 3;

            string[] signs = new string[length];

            for (int i = 0; i < length; i++)
            {
                long n = long.Parse(Console.ReadLine());

                signs[i] = CheckSign(n);
            }

            int counter = 0;

            bool isZero = false;

            for (int i = 0; i < length; i++)
            {
                if (signs[i] == "")
                {
                    isZero = true;

                    Console.WriteLine("zero");

                    break;
                }

                if (signs[i] == "-")
                {
                    counter++;
                }
            }

            if ((counter == 2 || counter == 0) && isZero == false)
            {
                Console.WriteLine("positive");
            }
            else if ((counter == 1 || counter == 3) && isZero == false)
            {
                Console.WriteLine("negative");
            }
        }

        public static string CheckSign(long n)
        {
            string result = "";

            if (n > 0)
            {
                result = "+";
            }
            else if (n < 0)
            {
                result = "-";
            }

            return result;
        }
    }
}
