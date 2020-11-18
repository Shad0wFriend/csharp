using System;

namespace _08_math_power
{
    class Program
    {
        static void Main(string[] args)
        {
            double fundament = double.Parse(Console.ReadLine());

            int power = int.Parse(Console.ReadLine());

            double result = MathPower(fundament, power);

            Console.WriteLine(result);
        }

        public static double MathPower(double fundament, int power)
        {
            double result = Math.Pow(fundament, power);

            return result;
        }
    }
}
