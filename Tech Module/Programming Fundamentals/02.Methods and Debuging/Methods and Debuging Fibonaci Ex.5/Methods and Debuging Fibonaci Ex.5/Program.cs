using System;


namespace Methods_and_Debuging_Fibonaci_Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());            
            Console.WriteLine(Fibonaci(n));
        }
        public static long Fibonaci(long n)
        {
            
            long fnext = 0;
            long flast = 1;
            long fibo = 1;
            for (int i = 1; i < n; i++)
            {
                fnext = flast + fibo;
                flast = fibo;
                fibo = fnext;
            }
            return fibo;
            
        }
    }
}
