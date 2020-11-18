using System;

namespace _14_floating_equility
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            bool isFloatingPart = false;

            string floatingPartA = "";

            foreach (char symbol in first)
            {
                if (symbol == '.')
                {
                    isFloatingPart = true;

                    continue;
                }

                if (isFloatingPart)
                {
                    floatingPartA += symbol.ToString();
                }
            }

            isFloatingPart = false;

            string floatingPartB = "";

            foreach (char symbol in second)
            {
                if (symbol == '.')
                {
                    isFloatingPart = true;

                    continue;
                }

                if (isFloatingPart)
                {
                    floatingPartB += symbol.ToString();
                }
            }

            bool isEqual = false;

            if (floatingPartA.Length > 6 && floatingPartB.Length > 6)
            {
                isEqual = true;
            }
            else
            {
                int floatNumberA = int.Parse(floatingPartA);
                int floatNumberB = int.Parse(floatingPartB);

                if (floatNumberA == floatNumberB)
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
