    class Person
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

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string ToString()
        {
            return $"{this.FirstName} {this.LastName} is a {this.Age} years old";
        }
    }

