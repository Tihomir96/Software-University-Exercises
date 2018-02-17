using System;

namespace _3.Ferrari
{
    public class Program
    {
        public static void Main()
        {
            var driver = Console.ReadLine();
            var ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari.ToString());

        }
    }
}
