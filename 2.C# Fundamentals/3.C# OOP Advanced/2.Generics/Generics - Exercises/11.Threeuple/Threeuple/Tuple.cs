using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Tuple<T,U>
    {
        public T First { get; private set; }
        public U Second { get; private set; }
        public Tuple(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }
        public override string ToString()
        {
            return $"{this.First} -> {this.Second}";
        }
    }
}
