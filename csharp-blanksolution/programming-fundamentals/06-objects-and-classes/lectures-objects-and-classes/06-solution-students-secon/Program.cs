using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_solution_students_secon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<object> objects = new List<object>();

            while (input != "end")
            {
                List<string> data = input.Split(' ').ToList();

                Student student = new Student(data[0], data[1], int.Parse(data[2]), data[3]);

                objects.Add(student);

                CheckUniqueStudent(objects, data[0], data[1]);

                input = Console.ReadLine();
            }

            string delimeter = Console.ReadLine();

            foreach (Student student in objects)
            {
                if (student.Town == delimeter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        public static void CheckUniqueStudent(List<object> objects, string firstName, string lastName)
        {
            int counter = 0;

            foreach (Student student in objects)
            {
                if (firstName == student.FirstName && lastName == student.LastName)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                foreach (Student student in objects)
                {
                    if (firstName == student.FirstName && lastName == student.LastName)
                    {
                        objects.RemoveAt(objects.IndexOf(student));

                        break;
                    }
                }
            }
        }
    }
}
