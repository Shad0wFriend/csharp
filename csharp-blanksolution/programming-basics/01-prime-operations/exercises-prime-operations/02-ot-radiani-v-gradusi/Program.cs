using System;

namespace _02_ot_radiani_v_gradusi
{
    class Program
    {
        static void Main(string[] args)
        {
            double radian = double.Parse(Console.ReadLine());
            double degree = radian * 180 / Math.PI;

            Console.WriteLine(Math.Round(degree));
        }
    }
}
