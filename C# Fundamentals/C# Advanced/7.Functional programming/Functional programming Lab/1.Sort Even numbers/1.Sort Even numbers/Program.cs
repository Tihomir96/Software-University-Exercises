﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sort_Even_numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(", ",Console.ReadLine().Split(new string[]{", "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(n=>n%2==0).OrderBy(n=>n).ToList()));
        }
    }
}
