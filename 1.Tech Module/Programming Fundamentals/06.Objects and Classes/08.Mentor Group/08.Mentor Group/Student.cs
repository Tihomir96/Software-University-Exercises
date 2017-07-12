using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Student
    {
        public List<string> Comments { get; set; } = new List<string>();
        public List<DateTime> AttendancyDates { get; set; } = new List<DateTime>();
        public string StudentName { get; set; }
    }
}
