using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Academy_Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string,List<double>>();
            for (int i = 0; i < n; i++)
            {
                var student = Console.ReadLine();
                var result = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(b => double.Parse(b, CultureInfo.InvariantCulture)).ToList();
                students.Add(student,result);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }

        }
    }
}
