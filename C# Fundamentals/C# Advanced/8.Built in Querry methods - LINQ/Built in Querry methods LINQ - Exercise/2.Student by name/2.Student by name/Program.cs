namespace _2.Student_by_name
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var lexicNames = new List<string>();
            while (input != "END")
            {
                var names = input.Split();
                var firstName = names[0];
                var secondName = names[1];
                if (firstName.CompareTo(secondName) == -1)
                {
                    lexicNames.Add(input);
                }
                input = Console.ReadLine();
            }
            foreach (var name in lexicNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
