using System;

namespace _06_reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            string temp = "";

            while (true)
            {
                char symbol = char.Parse(Console.ReadLine());

                temp += symbol;

                if (counter == 3)
                {
                    break;
                }

                counter++;
            }

            string reversed = "";

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                reversed += temp[i] + " ";
            }

            Console.WriteLine(reversed);
        }
    }
}
