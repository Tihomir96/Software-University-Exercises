using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Students_Results
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name","CAdv","COOP","AdvOOP","Average"));
            for (int index = 0; index < n; index++)
            {
                var input = Console.ReadLine().Split(new []{'-'},StringSplitOptions.RemoveEmptyEntries);
                var student = input[0];
                var results = input[1].Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse).ToArray();
                var avg = results.Average();
                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",student,results[0],results[1],results[2],avg));
            }
        }
    }
}
