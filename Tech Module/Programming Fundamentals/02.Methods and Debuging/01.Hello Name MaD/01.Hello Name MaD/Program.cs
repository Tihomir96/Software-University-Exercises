using System;

namespace _01.Hello_Name_MaD
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Name(name);
        }
        public static void Name(string name)
        {
            
            Console.WriteLine($"Hello, {name}!");

        }
    }

}
