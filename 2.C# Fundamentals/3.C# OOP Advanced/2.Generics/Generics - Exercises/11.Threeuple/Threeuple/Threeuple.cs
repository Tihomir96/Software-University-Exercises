using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class Threeuple<T,U,P>
    {
        public T FirstElement{ get; private set; }
        public U SecondElement { get; private set; }
        public P ThirdElement { get; private set; }
        public Threeuple(T first, U second, P third)
        {
            this.FirstElement = first;
            this.SecondElement = second;
            this.ThirdElement = third;
        }
        public override string ToString()
        {
            return $"{this.FirstElement} -> {this.SecondElement} -> {this.ThirdElement}";
        }
    }
}
