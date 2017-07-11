using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Students_join
{
    class Program
    {
        static void Main()
        {
            var students =new List<Student>();
            var specs = new List<StudentSpecialty>();
            string input;
            while ((input=Console.ReadLine())!= "Students:")
            {
                var tokens = input.Split(' ');
                specs.Add(new StudentSpecialty(tokens[0]+ " " +tokens[1], int.Parse(tokens[2])));
            }
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(' ');
                students.Add(new Student(tokens[1] + " " + tokens[2], int.Parse(tokens[0])));
            }
            specs.Join(students, sp => sp.FacultyNumber, st => st.FacultyNumber, (sp, st) => new
            {
                Name = st.StudName,
                FacNum = st.FacultyNumber,
                Spec = sp.SpecName
            }).OrderBy(st => st.Name).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.FacNum} {x.Spec}"));
        }
    }

    public class StudentSpecialty
    {
        public string SpecName { get; set; }
        public int FacultyNumber { get; set; }

        public StudentSpecialty(string name, int num)
        {
            this.SpecName = name;
            this.FacultyNumber = num;
        }
    }
    public class Student
    {
        public string StudName { get; set; }
        public int FacultyNumber { get; set; }

        public Student(string name, int num)
        {
            this.StudName = name;
            this.FacultyNumber = num;
        }
    }
}
