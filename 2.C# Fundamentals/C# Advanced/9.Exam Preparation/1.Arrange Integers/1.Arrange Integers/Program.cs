using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Arrange_Integers
{
    class Program
    {
        static void Main()
        {
            var inputArr = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var sortedDict = new SortedDictionary<string,string>();
            var num = string.Empty;
            for (int i = 0; i < inputArr.Length; i++)
            {
                var numbers = inputArr[i].ToString();
                
                        var sb = new StringBuilder();
                    foreach (var number in numbers)
                    {
                        if (number=='0')
                        {
                            num = "zero";
                        }
                        if (number=='1')
                        {
                            num = "one";
                        }
                        if (number =='2')
                        {
                            num = "two";
                        }
                        if (number=='3')
                        {
                            num = "three";
                        }
                        if (number=='4')
                        {
                            num = "four";
                        }
                        if (number=='5')
                        {
                            num = "five";
                        }
                        if (number=='6')
                        {
                            num = "six";
                        }
                        if (number == '7')
                        {
                            num = "seven";
                        }
                        if (number=='8')
                        {
                            num= "eight";
                        }
                        if (number == '9')
                        {
                            num = "nine";
                        }
                        sb.Append(num).Append('-');
                    }
                    sb.ToString().TrimEnd('-');

                if (sortedDict.ContainsKey(sb.ToString()))
                {
                    sortedDict[sb.ToString()] += ", "+inputArr[i].ToString();
                }
                else
                {
                    sortedDict.Add(sb.ToString(),inputArr[i].ToString());                    
                }
            }
            var list = sortedDict.OrderBy(k => k.Key).Select(x => x.Value).ToList();          
            Console.WriteLine(string.Join(", ",list));
            
        }
    }
}
