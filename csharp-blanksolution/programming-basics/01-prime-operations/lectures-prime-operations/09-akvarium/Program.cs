using System;

namespace _09_akvarium
{
    class Program
    {
        static void Main(string[] args)
        {
            //working with cantimeters
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double unusableVolume = volume * percentage / 100;
            double usableVolume = volume - unusableVolume;

            Console.WriteLine($"{usableVolume / 1000:F3}");
        }
    }
}
