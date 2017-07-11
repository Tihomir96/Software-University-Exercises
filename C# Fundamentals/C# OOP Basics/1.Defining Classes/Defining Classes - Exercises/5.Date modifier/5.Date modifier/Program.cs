using System;

namespace _05._2.Date_Modifier
{
    public class Program
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secDate = Console.ReadLine();

            Date_Modifier.DateModifier a = new DateModifier();
            Console.WriteLine(Math.Abs(a.Difference(firstDate, secDate)));
        }
    }
}
