using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main()
        {
            var line = "??ecnarF?? ??kramneD?? 0:0";
            var key = "??";
            var firstWordStart = line.IndexOf(key);
            var firstWordEnd = line.IndexOf(key, firstWordStart + key.Length);
            var secondWordStart = line.IndexOf(key, firstWordEnd + key.Length);
            var secondWordEnd = line.IndexOf(key, secondWordStart + key.Length);


            Console.WriteLine(line.Substring(firstWordStart + key.Length, firstWordEnd-(firstWordStart + key.Length)));
            Console.WriteLine(line.Substring(secondWordStart + key.Length, secondWordEnd-(secondWordStart + key.Length)));

            //var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            //var commands = Console.ReadLine().Split(' ');

            //while (commands[0] != "end")
            //{
            //    var command = commands[0];

            //    if (command == "swap")
            //    {
            //        var index1 = long.Parse(commands[1]);
            //        var index2 = long.Parse(commands[2]);
            //        SwapInts(input, index1, index2);
            //    }
            //    if (command == "multiply")
            //    {
            //        var index1 = long.Parse(commands[1]);
            //        var index2 = long.Parse(commands[2]);
            //        Mutliplier(input, index1, index2);
            //    }
            //    if (command == "decrease")
            //    {
            //        for (int i = 0; i < input.Length; i++)
            //        {
            //            input[i] = input[i] - 1;
            //        }
            //    }
            //    commands = Console.ReadLine().Split()   
            //}

            //Console.WriteLine(string.Join(", ", input));
        }




        private static void Mutliplier(long[] input, long index1, long index2)
        {
            input[index1] = input[index1] * input[index2];


        }

        public static void SwapInts(long[] input, long index1, long index2)
        {
            long temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;

        }
    }
}
