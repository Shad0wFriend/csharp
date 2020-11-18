using System;

namespace _08_triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write(rows + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
