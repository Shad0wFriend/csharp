﻿using System;

namespace _06_foreign_languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA": Console.WriteLine("English"); break;
                case "Mexico":
                case "Argentina":
                case "Spain": Console.WriteLine("Spanish"); break;
                default: Console.WriteLine("unknown"); break;
            }
        }
    }
}
