using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyCustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private IList<T> customList;
        public MyCustomList()
        {
            this.customList = new List<T>();
        }
        public void Add(T element)
        {
            this.customList.Add(element);
        }
        public T Remove(int index)
        {
            T element = this.customList[index];
            this.customList.RemoveAt(index);
            return element;
        }
        public int Count => this.customList.Count;
        public bool Contains(T element)
        {
            if (this.customList.Contains(element))
            {
                return true;
            }
            return false;
        }
        public void Swap (int index1, int index2)
        {
            var temp = this.customList[index1];
            this.customList[index1] = this.customList[index2];
            this.customList[index2] = temp;
        }
        public int CountGreaterElements(T element)
        {
            int counter = this.customList.Count(x => x.CompareTo(element) > 0);
            return counter;
        }
        public T Max()
        {
            return this.customList.Max();
        }

        public T Min()
        {
            return this.customList.Min();
        }
        public string Print()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < this.customList.Count; i++)
            {
                sb.AppendLine(this.customList[i].ToString());
            }

            return sb.ToString().Trim();
        }

        public IList<T> GetList()
        {
            return this.customList;
        }
        public void Sort()
        {
            this.customList = this.customList.OrderBy(x => x).ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.customList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
