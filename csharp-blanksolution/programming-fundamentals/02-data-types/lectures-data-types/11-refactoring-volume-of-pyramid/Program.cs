﻿using System;

namespace _11_refactoring_volume_of_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double volume = (length * width * height) / 3;
            
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:F2}");
        }
    }
}
