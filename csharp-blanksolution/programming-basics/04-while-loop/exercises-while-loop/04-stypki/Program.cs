using System;

namespace _04_stypki
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            string input = "";
            int steps = 0;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    steps = int.Parse(Console.ReadLine());

                    totalSteps += steps;

                    if (totalSteps >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
                        break;
                    }
                }
                else
                {
                    steps = int.Parse(input);
                }

                totalSteps += steps;

                if (totalSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
            }
        }
    }
}
