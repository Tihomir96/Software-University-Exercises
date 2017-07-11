using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _3.Manking
{
    public class Student:Human
    {
        private string facultyNumber;

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                var reg = new Regex(@"^[a-zA-Z0-9]{5,10}$");
                if (!reg.IsMatch(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }                
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber ) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"First Name: {this.FirstName}").Append(Environment.NewLine);
            sb.Append($"Last Name: {this.LastName}").Append(Environment.NewLine);
            sb.Append($"Faculty number: {this.FacultyNumber}").Append(Environment.NewLine);
            return sb.ToString();
        }
    }
}
