using System;
using System.Linq;

namespace CompanyRoster
{
    class Program
    {
        public class Employee
        {
            public string Name { get; set; }

            public decimal Salary { get; set; }
            
            public string Department { get; set; }
        }
        
        static void Main(string[] args)
        {
            int employeesCount = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[employeesCount];

            for (int i = 0; i < employeesCount; i++)
            {
                string[] employeesData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = employeesData[0];
                decimal salary = decimal.Parse(employeesData[1]);
                string department = employeesData[2];

                Employee employee = new Employee()
                {
                    Name = name,
                    Salary = salary,
                    Department = department
                };

                employees[i] = employee;
            }

            var ordered = employees
                .GroupBy(e => e.Department)
                .Select(e => new 
                {
                    Department = e.Key,
                    DepartmentAverageSalary = e.Average(emp => emp.Salary),
                    Employees = e.OrderByDescending(emp => emp.Salary)
                })
                .OrderByDescending(dep => dep.DepartmentAverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {ordered.Department}");

            foreach (var employee in ordered.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }

        }                   
    }
}
