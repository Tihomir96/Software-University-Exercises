namespace _4.Doubles_Average
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"{Console.ReadLine().Split().Select(double.Parse).ToList().Average():f2}");                
        }
    }
}
