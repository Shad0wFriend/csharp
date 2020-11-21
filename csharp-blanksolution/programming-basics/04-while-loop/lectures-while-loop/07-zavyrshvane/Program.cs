using System;

namespace _07_zavyrshvane
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double average = 0;
            int counter = 1;

            while (true)
            {
                double grade = double.Parse(Console.ReadLine());

                average += grade;

                if (counter == 12)
                {
                    if (grade >= 4.00)
                    {
                        average = average / counter;

                        Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

                counter++;
            }
        }
    }
}
