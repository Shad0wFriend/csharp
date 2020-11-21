using System;

namespace _05_zala_za_tanci
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double wdith = double.Parse(Console.ReadLine());
            double sideOfWordrobe = double.Parse(Console.ReadLine());

            double room = lenght * wdith;
            double wordrobe = sideOfWordrobe * sideOfWordrobe;
            double bench = room / 10;
            double space = room - (wordrobe + bench);

            double dancerSpace = space * 2.8;

            Console.WriteLine(Math.Floor(dancerSpace));
        }
    }
}
