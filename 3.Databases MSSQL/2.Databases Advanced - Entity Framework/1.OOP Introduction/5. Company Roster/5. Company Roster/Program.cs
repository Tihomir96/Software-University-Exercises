using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        var employees = new List<Employee>();

        for (int i = 0; i < num; i++)
        {
            var personInfo = Console.ReadLine().Split();
            var name = personInfo[0];
            var salary = double.Parse(personInfo[1]);
            var position = personInfo[2];
            var department = personInfo[3];
            int age;
            string email;

            if (personInfo.Length == 5)
            {
                if (!int.TryParse(personInfo[4], out age))
                {
                    email = personInfo[4];
                    employees.Add(new Employee(name, salary, position, department, email));
                    continue;
                }
                else
                {
                    age = int.Parse(personInfo[4]);
                    employees.Add(new Employee(name, salary, position, department, age));
                    continue;
                }
            }
            else if (personInfo.Length == 6)
            {
                email = personInfo[4];
                age = int.Parse(personInfo[5]);
                employees.Add(new Employee(name, salary, position, department, email, age));
                continue;
            }

            employees.Add(new Employee(name, salary, position, department));
        }

        var filteredEmployees = employees
            .Select(e => new
            {
                AvgSalary = employees.Average(em => em.Salary),
                Department = e.Department
            })
            .GroupBy(e => e.Department)
            .OrderByDescending(e => employees.Where(em => em.Department == e.Key).Average(s => s.Salary))
            .First();

        Console.WriteLine($"Highest Average Salary: {filteredEmployees.Key}");
        foreach (var employee in employees.Where(e => e.Department == filteredEmployees.Key).OrderByDescending(e => e.Salary))
        {
            var noAge = -1;
            var noMail = "n/a";
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {(employee.Email == null ? noMail : employee.Email)} {(employee.Age ==0 ? noAge : employee.Age)}");
        }
    }
}


