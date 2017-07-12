using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var baseN = (input[1]);
            var num = BigInteger.Parse(input[0]);


            BigInteger sum=0;
            var baseN1 = BigInteger.Parse(baseN);
            for (int i = 0; i < baseN.Length; i++)
            {
                var number = baseN1 % 10;
                BigInteger result = (number * MathPower(num,i));
                sum += result;

                baseN1 = baseN1 / 10;


            }
            Console.WriteLine(sum);

            


        }
        public static BigInteger MathPower(BigInteger a, int b)
        {

            BigInteger sum=1;
            for (int i = 1; i <=b ; i++)
            {
                sum *= a;
            }
                return sum;
        }
    }
}
