using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Average_Grades
{
    public class Average_Grades
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                var line = Console.ReadLine().Split(' ');
                student.Name = line[0];
                student.Grades = new List<double>();
                for (int j = 1; j < line.Length; j++)
                {
                    student.Grades.Add(double.Parse(line[j]));
                }
                students.Add(student);
                student.Average();
            }
            students = students.FindAll(s => s.Average() >= 5);
            var spisuk = students.OrderBy(student => student.Name).ThenByDescending(grades => grades.Average());
            foreach (var spis in spisuk)
            {
                    Console.WriteLine($"{spis.Name} -> {spis.Average().ToString("0.00")}");
            }
        }
    }
}
