﻿using System;

namespace _07_concat_names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine(firstName + delimeter + secondName);
        }
    }
}
