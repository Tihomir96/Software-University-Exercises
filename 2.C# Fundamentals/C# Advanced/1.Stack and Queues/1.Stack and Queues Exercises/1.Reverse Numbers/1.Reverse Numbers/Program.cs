using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Reverse_Numbers
{
    public class Program
    {
            public static void Main(string[] args)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                var stack = new Stack<string>();

                for (int i = 0; i < input.Length; i++)
                {
                    stack.Push(input[i]);
                }
                while (stack.Count>0)
                {
                    Console.Write(stack.Pop()+ " ");                   
                }
            }
        }
    }

