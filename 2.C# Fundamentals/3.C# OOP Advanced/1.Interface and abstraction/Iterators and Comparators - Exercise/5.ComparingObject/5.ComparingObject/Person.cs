using System;

namespace _5.ComparingObject
{
    public class Person:IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public int CompareTo(Person other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
            if (nameComparison != 0) return nameComparison;
            var ageComparison = Age.CompareTo(other.Age);
            if (ageComparison != 0) return ageComparison;
            return string.Compare(Town, other.Town, StringComparison.Ordinal);
        }
    }
}
