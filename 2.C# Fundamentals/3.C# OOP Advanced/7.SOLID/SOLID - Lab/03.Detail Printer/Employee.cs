using System.Net.Http.Headers;

namespace _03.Detail_Printer
{
    public class Employee
    {
        public Employee(string name)
        {
            this.name = name;
        }

        private string name;
            public override string ToString()
        {
            return $"Name: {this.name}";
        }
    }
}