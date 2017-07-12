using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.Mentor_Group
{
    public class Program
    {
        public static void Main()
        {

            var input = Console.ReadLine();
            var studentsDictionary = new Dictionary<string, Student>();
            while (input != "end of dates")

            {
                
                var line = input.Split(' ', ',');
                var name = line[0];
                Student student;
                if (studentsDictionary.ContainsKey(name))
                {
                    student = studentsDictionary[name];
                }
                else
                {
                    student = new Student();
                    student.StudentName = name;
                    studentsDictionary.Add(name, student);
                }
                for (int i = 1; i < line.Length; i++)
                {
                    string dates = line[i];
                    var datesAttended = DateTime.ParseExact(dates, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    student.AttendancyDates.Add(datesAttended);


                }
                    input = Console.ReadLine();

            }
            var input2 = Console.ReadLine();

            while (input2 != "end of comments")
            {
                var lines2 = input2.Split('-');
                var nameOfStud = lines2[0];
                var comments = lines2[1];
                if (studentsDictionary.ContainsKey(lines2[0]))
                {
                    studentsDictionary[nameOfStud].Comments.Add(comments);
                }
                input2 = Console.ReadLine();
            }
            
            foreach (var item in studentsDictionary.OrderBy(n =>n.Key))
            {

                Console.WriteLine($"{item.Key}");
                Console.WriteLine($"Comments:");
                foreach (var comment in item.Value.Comments)
                {
                Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var dates in item.Value.AttendancyDates.OrderBy(d=>d))
                {
                    Console.WriteLine($"-- {dates.ToString("dd/MM/yyyy")}");
                }
                
            }

        }
    }
}
