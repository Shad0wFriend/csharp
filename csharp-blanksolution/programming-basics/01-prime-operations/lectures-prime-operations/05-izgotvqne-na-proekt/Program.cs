using System;

namespace _05_izgotvqne_na_proekt
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());

            Console.WriteLine($"The architect {name} will need {numberOfProjects * 3} hours to complete {numberOfProjects} project/s.");
            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", name, numberOfProjects * 3, numberOfProjects);
        }
    }
}
