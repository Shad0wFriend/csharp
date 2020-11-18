using System;

namespace _03_elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPersons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            if (countOfPersons % capacity == 0)
            {
                courses = countOfPersons / capacity;
            }
            else
            {
                courses = (countOfPersons / capacity) + 1;
            }

            Console.WriteLine(courses);
        }
    }
}
