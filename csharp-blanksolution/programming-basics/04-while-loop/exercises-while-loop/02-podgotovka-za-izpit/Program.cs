using System;

namespace _02_podgotovka_za_izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGrades = int.Parse(Console.ReadLine());
            int counter = 0;
            int counterPoorGrades = 0;
            double average = 0;
            string previousTask = "";
            string task = "";

            while (true)
            {
                previousTask = task;

                task = Console.ReadLine();

                if (task == "Enough")
                {
                    average = average / counter;
                    Console.WriteLine($"Average score: {average:F2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {previousTask}");
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                average += grade;

                if (grade <= 4.00)
                {
                    counterPoorGrades++;
                }

                if (counterPoorGrades == poorGrades)
                {
                    Console.WriteLine("You need a break, {0} poor grades.", counterPoorGrades);
                    break;
                }

                counter++;
            }
        }
    }
}
