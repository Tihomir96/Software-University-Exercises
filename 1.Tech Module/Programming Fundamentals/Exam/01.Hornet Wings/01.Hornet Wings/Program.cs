using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceFor1000flaps = double.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceFor1000flaps;
            var flapsPerSec = 100;
            var hornetFlaps = wingFlaps / flapsPerSec;
            var seconds = wingFlaps / (p) * 5;
            var totalSec = hornetFlaps + seconds;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalSec} s.");

        }
    }
}
