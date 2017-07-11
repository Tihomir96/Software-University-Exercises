using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double metersPerSec = distance / (hours * 3600 + minutes * 60 + seconds);
            double kmPerHour = (distance / 1000) / (hours + (minutes / 60) + (seconds / 3600));
            double milesPerHour = (distance / 1609) / (hours + (minutes / 60) + (seconds / 3600));
            Console.WriteLine("{0}\n{1}\n{2}",metersPerSec,(float)kmPerHour,milesPerHour );

        }
    }
}
