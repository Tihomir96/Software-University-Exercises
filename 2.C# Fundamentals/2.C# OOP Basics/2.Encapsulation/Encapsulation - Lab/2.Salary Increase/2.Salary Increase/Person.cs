    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public Person(string firstName, string lastName, int age, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.salary:F2} leva";
        }
        private double salary;

        public double Salary
        {
            get { return this.salary; }
        }

        public void IncreaseSalary(double percent)
        {
            if (this.age > 30)
            {
                this.salary += this.salary * percent / 100;
            }
            else
            {
                this.salary += this.salary * percent / 200;
            }
        }

    }
