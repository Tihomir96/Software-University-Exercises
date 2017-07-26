using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _1.Generic_Box
{
    public class Program
    {
        public static void Main()
        {
            var listofBox = new List<Box<double>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                listofBox.Add(new Box<double>(double.Parse(Console.ReadLine())));
            }
            var element = double.Parse(Console.ReadLine());
            Console.WriteLine(GetGreaterElementCount(listofBox,element));
        }

        public static int GetGreaterElementCount<T>(List<Box<T>> listOfBox, T element)
            where T :IComparable
        {
            int counter = listOfBox.Count(b=>b.Value.CompareTo(element)>0);
            return counter;
        }
    }
}
