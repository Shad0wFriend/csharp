using System;
using System.Collections.Generic;
using System.Text;

namespace _06_solution_students_secon
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public Student()
        {

        }

        public Student(string v1, string v2, int v3, string v4)
        {
            this.FirstName = v1;
            this.LastName = v2;
            this.Age = v3;
            this.Town = v4;
        }
    }
}
