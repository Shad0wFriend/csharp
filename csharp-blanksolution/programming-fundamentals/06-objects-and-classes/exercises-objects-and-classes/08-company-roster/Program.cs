using System;
using System.Linq;
using System.Collections.Generic;

namespace _08_company_roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                string[] data = input.Split(' ');

                Employee employee = new Employee(data[0], decimal.Parse(data[1]), data[2]);

                employees.Add(employee);
            }

            List<Employee> sorted = new List<Employee>();

            SortEmployees(employees, sorted);

            string prev = FindHighestSalaryDepartment(sorted);

            List<Employee> tmp = new List<Employee>();

            foreach (Employee employee in sorted)
            {
                if (prev == employee.Department)
                {
                    tmp.Add(employee);
                }
            }

            Console.WriteLine($"Highest Average Salary: {prev}");

            foreach (Employee employee in tmp.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }

        public static void SortEmployees(List<Employee> employees, List<Employee> sorted)
        {
            string department = "";

            for (int i = 0; i < employees.Count; i++)
            {
                department = employees[0].Department;

                for (int k = 0; i < employees.Count; k++)
                {
                    if (k >= employees.Count)
                    {
                        break;
                    }

                    if (department == employees[k].Department)
                    {
                        sorted.Add(employees[k]);

                        int index = employees.IndexOf(employees[k]);

                        employees.RemoveAt(index);

                        k = -1;
                    }
                }

                i = -1;
            }
        }

        public static string FindHighestSalaryDepartment(List<Employee> sorted)
        {
            string departmentA = sorted[0].Department;

            string departmentB = "";

            string department = "";

            decimal a = 0;

            decimal b = 0;

            decimal biggest = 0;

            bool flag = false;

            bool isCapsuled = false;

            foreach (Employee employee in sorted)
            {
                if (employee.Department != departmentA)
                {
                    if (isCapsuled == false)
                    {
                        departmentB = employee.Department;

                        isCapsuled = true;
                    }

                    b += employee.Salary;

                    if (flag == false)
                    {
                        if (employee.Department != departmentB)
                        {
                            b -= employee.Salary;

                            if (a > b)
                            {
                                department = departmentA;

                                biggest = a;
                            }
                            else if (a < b)
                            {
                                department = departmentB;

                                biggest = b;
                            }

                            a = 0;

                            b = 0;

                            departmentA = employee.Department;

                            a += employee.Salary;

                            flag = true;
                        }
                    }
                    else
                    {
                        if (biggest < a)
                        {
                            biggest = a;

                            a = 0;

                            a += employee.Salary;

                            department = departmentA;

                            departmentA = employee.Department;
                        }
                        else
                        {
                            departmentA = employee.Department;

                            a = 0;

                            a += employee.Salary;
                        }
                    }
                }
                else
                {
                    a += employee.Salary;
                }

                if (sorted.IndexOf(employee) == sorted.Count - 1)
                {
                    if (biggest < a)
                    {
                        biggest = a;

                        department = employee.Department;
                    }
                }
            }

            return department;
        }
    }
}
