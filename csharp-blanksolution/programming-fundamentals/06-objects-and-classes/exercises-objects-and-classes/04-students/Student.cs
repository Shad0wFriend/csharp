using System;
using System.Collections.Generic;
using System.Text;

namespace _04_students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public Student(string v1, string v2, double v3)
        {
            this.FirstName = v1;
            this.LastName = v2;
            this.Grade = v3;
        }
    }
}
