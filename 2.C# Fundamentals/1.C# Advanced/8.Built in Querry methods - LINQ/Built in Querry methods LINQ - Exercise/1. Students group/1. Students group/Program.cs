namespace _1.Students_group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var list = new List<string>();
            while (input != "END")
            {
                var input1= input.TrimEnd();
                if (input1.EndsWith("2"))
                {
                    var name =input1.TrimEnd('2');
                    list.Add(name);
                }
                input = Console.ReadLine();
            }

            foreach (var name in list.OrderBy(x=>x))
            {
                Console.WriteLine(name);
            }
        }
    }
}
