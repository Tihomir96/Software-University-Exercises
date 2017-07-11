using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Primes_in_Given_Range_MaD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primes = FindPrimesInRange(startNum,endNum);
            string s = string.Join(", ", primes);
            Console.Write("{0}", s);

        }
        public static List<int> FindPrimesInRange(int startNum,int endNum)
        {
            List<int> primes = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
        public static bool IsPrime(int num)
        {

            if ((num & 1) == 0)
            {
                if (num == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= num; i += 2)
            {
                if ((num % i) == 0)
                {

                    return false;
                }
            }
            return num != 1;
        }
    }
}
