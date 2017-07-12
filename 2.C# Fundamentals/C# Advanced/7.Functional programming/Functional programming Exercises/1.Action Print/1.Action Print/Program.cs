namespace _1.Action_Print
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Action<List<string>> print = message => Console.WriteLine(string.Join($"{Environment.NewLine}",message));
            print(input);

        }
    }
}
