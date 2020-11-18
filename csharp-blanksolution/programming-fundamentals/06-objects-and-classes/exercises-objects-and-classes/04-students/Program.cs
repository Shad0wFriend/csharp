using System;
using System.Linq;
using System.Collections.Generic;

namespace _04_students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 1; i <= n; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                Student student = new Student(data[0], data[1], double.Parse(data[2]));

                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(c => c.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}
