using System.Collections.Generic;

namespace _6.Strategy_Patern
{
    class AgeComparator:IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
