using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Sino_the_Walker
{
    class Program
    {
        static void Main()
        {

            var firstInput = Console.ReadLine();
            var date = new DateTime();
            date = DateTime.ParseExact(firstInput, "HH:mm:ss", CultureInfo.InvariantCulture);
            double steps = double.Parse(Console.ReadLine())%86400;
            double timeForStep = double.Parse(Console.ReadLine())%86400;
            double time = steps * timeForStep;
            date = date.AddSeconds(time);
            string output = date.ToString("HH:mm:ss");
            Console.WriteLine($"Time Arrival: {output}");



            


        }
    }
}
