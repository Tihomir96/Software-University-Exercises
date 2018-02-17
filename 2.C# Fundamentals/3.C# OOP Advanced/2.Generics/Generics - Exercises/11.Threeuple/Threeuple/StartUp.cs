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
            string town = input[3];
            var strTuple = new Threeuple<string, string, string>(name, adress, town);
            Console.WriteLine(strTuple);

            var secInput = Console.ReadLine().Split(' ');
            string secName = secInput[0];
            int litersOfBeer = int.Parse(secInput[1]);
            bool drunkOrNot = false;
            if (secInput[2] == "drunk")
            {
                drunkOrNot = true;
            }
            var strIntTuple = new Threeuple<string, int,bool>(secName, litersOfBeer,drunkOrNot);
            Console.WriteLine(strIntTuple);

            var thirdInput = Console.ReadLine().Split(' ');
            string thridName = thirdInput[0];
            double accBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            var intDoubleTuple = new Threeuple<string, double,string>(thridName, accBalance, bankName);
            Console.WriteLine(intDoubleTuple);
        }
    }
}
