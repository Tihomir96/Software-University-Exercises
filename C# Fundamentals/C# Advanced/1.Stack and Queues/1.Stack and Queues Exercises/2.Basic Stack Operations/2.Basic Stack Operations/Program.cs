using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            var elements = input1[0];
            int elementsToPop =input1[1];
            int x = input1[2];

            var input2 = Console.ReadLine().Split(' ').ToArray();

            var stack = new Stack<int>();
        
            for (int i = 0; i < elements; i++)
            {
                stack.Push(int.Parse(input2[i]));
            }
            for (int i = 0; i < elementsToPop ; i++)
            {
               
                stack.Pop();
                
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        
            
        }
    }
}
