using System;
using System.Text;

namespace _3.Manking
{
    public class Worker:Human
    {
        public Worker(string firstName,string lastName,decimal weekSalary,decimal workHoursPerDay):base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        private decimal SalaryPerHour()
        {
            return this.WeekSalary / 5 / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            var sb= new StringBuilder();
            sb.Append($"First Name: {this.FirstName}").Append(Environment.NewLine);
            sb.Append($"Last Name: {this.LastName}").Append(Environment.NewLine);
            sb.Append($"Week Salary: {this.WeekSalary:f2}").Append(Environment.NewLine);
            sb.Append($"Hours per day: {this.WorkHoursPerDay:f2}").Append(Environment.NewLine);
            sb.Append($"Salary per hour: {this.SalaryPerHour():f2}");
            return sb.ToString();
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }


    }
}
