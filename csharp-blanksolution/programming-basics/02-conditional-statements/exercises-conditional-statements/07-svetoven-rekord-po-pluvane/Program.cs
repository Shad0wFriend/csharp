using System;

namespace _07_svetoven_rekord_po_pluvane
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double slow = distance / 15;
            double flooredSlow = Math.Floor(slow);

            double slowTime = flooredSlow * 12.5;

            double time = (timeForOneMeter * distance) + slowTime;

            if (time >= record)
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", time - record);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", time);
            }
        }
    }
}
