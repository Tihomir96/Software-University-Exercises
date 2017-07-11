namespace _1.Take_two
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            Console.ReadLine().Split().Select(int.Parse).Where(n => 10 <= n && n <= 20).Distinct().Take(2).ToList()
                .ForEach(x => Console.Write(x+" "));
        }
    }
}
