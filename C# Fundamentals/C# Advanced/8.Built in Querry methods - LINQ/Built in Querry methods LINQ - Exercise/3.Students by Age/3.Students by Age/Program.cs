namespace _3.Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string,int>();
            while (input!="END")
            {
                var studntTokens =input.Split();
                result.Add(studntTokens[0]+ " "+ studntTokens[1], int.Parse(studntTokens[2]));    
                input = Console.ReadLine();
            }
            foreach (var student in result.Where(x=> 18<=x.Value && x.Value <=24))
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
            
        }
    }
}
