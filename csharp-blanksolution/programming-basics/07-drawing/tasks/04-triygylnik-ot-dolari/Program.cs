﻿using System;

namespace _04_triygylnik_ot_dolari
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int k = 0; k < rows; k++)
                {
                    Console.Write('$' + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
