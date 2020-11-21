using System;

namespace _06_rombche_ot_zvezdichki
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int boundary = (2 * (n - 1)) + 1;

            string stars = "";

            for (int i = 1; i <= n; i++)
            {
                string whiteSpaces = new string(' ', n - i);

                for (int k = 1; k <= i; k++)
                {
                    stars += "* ";
                }

                Console.WriteLine(whiteSpaces + stars + whiteSpaces);

                stars = "";
            }

            int counter = 1;

            for (int i = boundary - n; i >= 1; i--)
            {
                string whiteSpaces = new string(' ', counter);

                for (int k = 0; k < i; k++)
                {
                    stars += "* ";
                }

                Console.WriteLine(whiteSpaces + stars + whiteSpaces);

                stars = "";

                counter++;
            }
        }
    }
}
