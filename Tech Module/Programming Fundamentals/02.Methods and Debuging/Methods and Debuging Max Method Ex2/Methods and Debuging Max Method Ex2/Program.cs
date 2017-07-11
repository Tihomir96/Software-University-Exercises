using System;

namespace Methods_and_Debuging_Max_Method_Ex2
{
    class Program
    {
        public static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int maxNum = Math.Max(GetMax(a, b), d);
            Console.WriteLine(maxNum);
        }
        public static int GetMax(int a, int b)
        {
       
            int maxAB = Math.Max(a, b);


            return maxAB;
        }
    }
}
