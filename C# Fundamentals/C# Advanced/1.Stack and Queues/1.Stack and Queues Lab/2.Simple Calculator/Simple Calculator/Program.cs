
namespace Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var reminder = input.Split(' ').Reverse();
            var stack = new Stack<string>(reminder);

            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var op = stack.Pop();
                var secondNum = int.Parse(stack.Pop());
                if (op == "+")
                {
                    stack.Push((firstNum+secondNum).ToString());
                }
                else
                {
                    stack.Push((firstNum-secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());

        }
    }
}
