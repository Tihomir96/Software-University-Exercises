using System;
using System.Collections;
using System.Collections.Generic;

namespace _3.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> elements;

        public Stack()
        {
            this.elements = new List<T>();
        }

        public void Push(List<T> elementsToAdd)
        {
            this.elements.AddRange(elementsToAdd);
        }

        public void Pop()
        {
            if (this.elements.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            this.elements.RemoveAt(this.elements.Count - 1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}