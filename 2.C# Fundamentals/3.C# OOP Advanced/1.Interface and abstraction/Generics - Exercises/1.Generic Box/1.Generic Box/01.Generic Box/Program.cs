using System;
using System.Runtime.InteropServices.ComTypes;

namespace _1.Generic_Box
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new Box<string>(Console.ReadLine()));              
            }
        

        }
    }
}
