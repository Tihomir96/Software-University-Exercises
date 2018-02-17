using System.Collections.Generic;

namespace _1.Generic_Box
{
    public class Box<T>
    {
        private List<T> data;

        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }
        
        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}: {this.Value}";
        }
    }
}
