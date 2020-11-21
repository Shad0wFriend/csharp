using System;

namespace _07_koledna_elha
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int boundary = n + 1;

            int counter = boundary;

            for (int i = 0; i < boundary; i++)
            {
                string whiteSpaces = new string(' ', counter);

                string stars = new string('*', i);

                if (counter == boundary)
                {
                    Console.WriteLine(whiteSpaces + '|' + whiteSpaces);

                    counter -= 2;
                }
                else
                {
                    Console.WriteLine(whiteSpaces + stars + " | " + stars + whiteSpaces);

                    counter--;
                }
            }
        }
    }
}
