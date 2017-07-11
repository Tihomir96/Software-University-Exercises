using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Values
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, Dictionary<string,string>>();
            var input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                var key = input[0];
                var innerKey = input[1];
                var innerValue = input[2];

                if (!dict.ContainsKey(key))
                {
                    var innerDict = new Dictionary<string, string>();
                    innerDict.Add(innerKey, innerValue);
                    dict.Add(key, innerDict);
                } else
                {
                    var innerDict = dict[key];
                    if(innerDict.ContainsKey(innerKey))
                    {
                        innerDict[innerKey] = innerValue;
                    } else
                    {
                        innerDict.Add(innerKey, innerValue);
                    }
                    
                }
                input = Console.ReadLine().Split(' ');
            }
            foreach (var item in dict.OrderByDescending(k=>k.Key))
            {
                Console.WriteLine($"{item.Key}");
                var count = 0;
                foreach (var it in item.Value.OrderBy(n=>n.Value.Length))
                {
                    count++;
                    Console.WriteLine($"{count}. {it.Key} - {it.Value}");
                }
            }
        }
    }
}
