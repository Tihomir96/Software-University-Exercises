using System;
using System.Linq;

namespace _3.Stack
{
    public class Program
    {
        public static void Main()
        {
            var stack = new Stack<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var inputTokens = input.Split();
                switch (inputTokens[0])
                {
                    case "Push":
                        var elementsToPush = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        stack.Push(elementsToPush.Skip(1).ToList());
                        break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                }
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}