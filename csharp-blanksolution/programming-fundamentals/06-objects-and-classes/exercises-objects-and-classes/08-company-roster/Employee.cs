using System;
using System.Collections.Generic;
using System.Text;

namespace _08_company_roster
{
    class Employee
    {
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public Employee(string v1, decimal v2, string v3)
        {
            this.Name = v1;
            this.Salary = v2;
            this.Department = v3;
        }
    }
}
