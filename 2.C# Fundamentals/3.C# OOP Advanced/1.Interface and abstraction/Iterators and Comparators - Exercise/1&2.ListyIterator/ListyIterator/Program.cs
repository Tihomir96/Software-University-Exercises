using System;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        public static void Main()
        {
            string input;
            var listyIterator = new ListyIterator<string>();
            while ((input = Console.ReadLine()) != "END")
            {
                var inputTokens = input.Split();
                switch (inputTokens[0])
                {
                    case "Create":
                        listyIterator = new ListyIterator<string>(input.Split().Skip(1).ToList());
                        break;
                    case "Move":
                        if (listyIterator.Move())
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "HasNext":
                        if (listyIterator.HasNext())
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(listyIterator.Print());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "PrintAll":
                        Console.WriteLine(string.Join(" ", listyIterator));
                        break;
                }
            }
        }
    }
}
