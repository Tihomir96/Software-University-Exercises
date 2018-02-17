using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            string name = input[0] +" "+ input[1];
            string adress = input[2];
            var strTuple = new Tuple<string, string>(name, adress);
            Console.WriteLine(strTuple);

            var secInput = Console.ReadLine().Split(' ');
            string secName = secInput[0];
            int litersOfBeer = int.Parse(secInput[1]);
            var strIntTuple = new Tuple<string, int>(secName, litersOfBeer);
            Console.WriteLine(strIntTuple);

            var thirdInput = Console.ReadLine().Split(' ');
            int intNum = int.Parse(thirdInput[0]);
            double doubleNum = double.Parse(thirdInput[1]);
            var intDoubleTuple = new Tuple<int, double>(intNum, doubleNum);
            Console.WriteLine(intDoubleTuple);
        }
    }
}
