using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    public class ListyIterator<T>:IEnumerable<T>
    {
        private int currentIndex;
        private List<T> elements;

        public ListyIterator()
        {
            this.elements=new List<T>();
        }
        
        public ListyIterator(List<T> collection)
        {
            this.elements = new List<T>(collection);
            currentIndex = 0;
        }
        
        public bool Move()
        {
            if (++this.currentIndex < this.elements.Count)
            {
                return true;
            }
            else
            {
                this.currentIndex--;
                return false;
            }
        }

        public bool HasNext()
        {
            if (currentIndex+1 <this.elements.Count )
            {
                return true;
            }
            return false;
        }
        public string Print()
        {
            if (currentIndex < this.elements.Count)
            {
                return $"{this.elements[currentIndex]}";
            }
            else
            {
                throw new ArgumentException("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elements.Count; i++)
            {                
                yield return this.elements[i];                
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
