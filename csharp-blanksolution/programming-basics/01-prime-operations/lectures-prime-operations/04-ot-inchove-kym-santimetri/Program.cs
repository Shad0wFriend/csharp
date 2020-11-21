using System;

namespace _04_ot_inchove_kym_santimetri
{
    class Program
    {
        static void Main(string[] args)
        {
            double inch = double.Parse(Console.ReadLine());
            double centimeters = inch * 2.54;

            Console.WriteLine("{0:F2}", centimeters);//formatirane do vtorata deseti4na zapetaq
            Console.WriteLine($"{centimeters:F2}");
        }
    }
}
