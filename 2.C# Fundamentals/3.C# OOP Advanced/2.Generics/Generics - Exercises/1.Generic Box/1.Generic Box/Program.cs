using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _1.Generic_Box
{
    public class Program
    {
        public static void Main()
        {
            string input;
            var customList = new CustomList<string>();
            while ((input=Console.ReadLine())!="END")
            {
                var tokens = input.Split();
                switch (tokens[0])
                {
                    case"Add":
                        customList.Add(tokens[1]);
                        break;
                    case "Remove":
                        customList.Remove(int.Parse(tokens[1]));
                        break;
                    case "Contains":
                        if (customList.Contains(tokens[1]))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }                        
                        break;
                    case "Swap":
                        customList.Swap(int.Parse(tokens[1]),int.Parse(tokens[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(customList.CountGreaterThan(tokens[1]));
                        break;
                    case "Max":
                        Console.WriteLine(customList.Max());
                        break;
                    case "Min":
                        Console.WriteLine(customList.Min());
                        break;
                    case "Sort":
                        customList = Sorter.Sort(customList);
                        break;
                    case "Print":
                        Console.WriteLine(customList.Print());
                        break;                        
                }
            }
        }
    }
}
