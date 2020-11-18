using System;

namespace _02_common_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ');

            string[] second = Console.ReadLine().Split(' ');

            for (int i = 0; i < second.Length; i++)
            {
                for (int k = 0; k < first.Length; k++)
                {
                    if (second[i] == first[k])
                    {
                        Console.Write(second[i] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
