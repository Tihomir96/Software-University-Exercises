using System;
using System.Linq;

namespace _4.Froggy
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[]{' ', ',' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var lake = new Lake(input);
            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
