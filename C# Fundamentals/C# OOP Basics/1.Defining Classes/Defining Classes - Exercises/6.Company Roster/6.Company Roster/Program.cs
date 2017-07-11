using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Company_Roster
{
    class Program
    {
        static void Main()
        {
            Employee employee;
            var n = int.Parse(Console.ReadLine());
            var employeeList = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var dep = input[2];
                employee = new Employee
                (input[0],
                    decimal.Parse(input[1]),
                    input[2],
                    input[3]
                );
                
                if (input.Length == 5)
                {
                    if (int.TryParse(input[4], out int age))
                    {
                        employee.Age = age;
                        employeeList.Add(employee);

                    }
                    else
                    {
                        employee.Email = input[4];
                    }
                }
                else if (input.Length == 6)
                {
                    employee.Email = input[4];
                    employee.Age = int.Parse(input[5]);
                }

                employeeList.Add(employee);
            }
            var result = employeeList.GroupBy(em => em.Department).Select(gr => new
            {
                Name = gr.Key,
                AverageSalary = gr.Average(em => em.Salary),
                Employees = gr
            }).OrderByDescending(gr => gr.AverageSalary).FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Name}");
            foreach (var emp in result.Employees.OrderByDescending(em=>em.Salary))
            {
                Console.WriteLine(emp.PrintEmployee());
            }
        }
    }
}
