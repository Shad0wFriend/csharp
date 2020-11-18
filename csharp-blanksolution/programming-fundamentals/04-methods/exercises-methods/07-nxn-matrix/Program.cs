using System;

namespace _07_nxn_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Matrix(number);
        }

        public static void Matrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k < number; k++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
