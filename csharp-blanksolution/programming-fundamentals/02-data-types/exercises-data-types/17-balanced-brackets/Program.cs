using System;

namespace _17_balanced_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLines = int.Parse(Console.ReadLine());

            string previous = "";

            int openning = 0;
            int closing = 0;

            bool isBalanced = true;

            for (int i = 1; i <= countOfLines; i++)
            {
                string input = Console.ReadLine();

                if (previous == ")" && input == "(")
                {
                    isBalanced = true;
                }

                if (previous == "(" && input == "(")
                {
                    Console.WriteLine("UNBALANCED");

                    isBalanced = false;

                    break;
                }
                else if (previous == ")" && input == ")")
                {
                    Console.WriteLine("UNBALANCED");

                    isBalanced = false;

                    break;
                }

                switch (input)
                {
                    case "(": openning++; previous = input; break;
                    case ")": closing++; previous = input; break;
                }
            }

            if (isBalanced)
            {
                if (openning == closing)
                {
                    Console.WriteLine("BALANCED");
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                }
            }
        }
    }
}
