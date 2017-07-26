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
            var listofBox = new List<Box<string>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                listofBox.Add(new Box<string>(Console.ReadLine()));
            }
            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swap<string>(listofBox, indexes[0], indexes[1]);
            foreach (var box in listofBox)
            {
                Console.WriteLine(box);
            }
        }

        private static void Swap<T>(List<Box<string>> listofBox, int i, int i1)
        {
            var temp = listofBox[i];
            listofBox[i] = listofBox[i1];
            listofBox[i1] = temp;
        }
    }
}
