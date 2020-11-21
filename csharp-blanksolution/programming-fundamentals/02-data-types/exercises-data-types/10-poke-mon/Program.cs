using System;

namespace _10_poke_mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());

            int originalPower = power;
            int counter = 0;
            double calculation = 0;

            while (true)
            {
                if(power - distance < distance)
                {
                    calculation = originalPower * 0.5;

                    if (calculation == (double)power)
                    {
                        int result = power / exhaustion;

                        if(result == 0)
                        {
                            power -= distance;
                            counter++;
                        }
                        else
                        {
                            power = result;
                        }

                        break;
                    }

                    power -= distance;
                    counter++;
                    break;
                }

                calculation = originalPower * 0.5;

                if(calculation == (double)power)
                {
                    power /= exhaustion;
                    break;
                }

                power -= distance;
                counter++;
            }
            
            Console.WriteLine(power);
            Console.WriteLine(counter);
        }
    }
}
