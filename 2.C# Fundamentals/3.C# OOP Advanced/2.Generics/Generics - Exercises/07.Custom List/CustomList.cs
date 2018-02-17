using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _1.Generic_Box
{
    public class CustomList<T>:ICustomList<T>
        where T: IComparable<T>
    {
        private IList<T> dataList;

        public CustomList()
        {
            this.dataList = new List<T>();
        }
        public void Add(T element)
        {
            this.dataList.Add(element);   
        }

        public T Remove(int index)
        {
            T result = this.dataList[index];
            this.dataList.RemoveAt(index);
            return result;
        }

        public bool Contains(T element)
        {
            if(this.dataList.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            var temp = this.dataList[index1];
            this.dataList[index1] = this.dataList[index2];
            this.dataList[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.dataList.Count(x => x.CompareTo(element) > 0);
        }

        public T Max()
        {
            return this.dataList.Max();
        }

        public T Min()
        {
            return this.dataList.Min();
        }

        public string Print()
        {
            var sb = new StringBuilder();
            foreach (var element in this.dataList)
            {
                sb.AppendLine(element.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
