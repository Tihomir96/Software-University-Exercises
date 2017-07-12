using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<long>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(v=>long.Parse(v)).ToArray();
                if (input[0] == 1)
                {
                    stack.Push(input[1]);
                }
                else if (input[0]==2)
                {
                    stack.Pop();
                }
                else if(input[0] == 3)
                {
                    
                }
            }
        }
    }
}
