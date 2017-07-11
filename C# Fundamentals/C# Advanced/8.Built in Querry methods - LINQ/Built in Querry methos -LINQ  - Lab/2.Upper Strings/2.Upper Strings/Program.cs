namespace _2.Upper_Strings
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            Console.ReadLine().Split().Select(x=> x.ToUpper()).ToList().ForEach( x=> Console.Write(x+" "));
        }
    }
}
