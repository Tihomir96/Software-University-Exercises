using System;
using System.Linq;

namespace _1.Generic_Box
{
    public class Sorter
    {
        public static CustomList<T> Sort<T>(CustomList<T> customList)
            where T:IComparable<T>
        {
            var temp = customList.DataList.OrderBy(x => x);
            return new CustomList<T>(temp);
        }
    }
}
